using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Kangelased
{
    class Program
    {
        static List<Kangelane> kangelased = new List<Kangelane>();
        static void LaeKangelased (string Failinimi)
        {
            string[] failiandmed = File.ReadAllLines(Failinimi);

            foreach (string rida in failiandmed)
            {
                string[] nimi_ja_koht = rida.Split('/');

                for (int i = 0; i < nimi_ja_koht.Length; i++)
                {
                    nimi_ja_koht[i] = nimi_ja_koht[i].Trim();
                }

                if (nimi_ja_koht[0].EndsWith("*"))

                {
                    kangelased.Add(new Superkangelane(nimi_ja_koht[0].TrimEnd('*'), nimi_ja_koht[1]));
                }

                else

                {
                    kangelased.Add(new Kangelane(nimi_ja_koht[0], nimi_ja_koht[1]));
                }

            }
        }
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.Clear();

            LaeKangelased("kangelased.txt");

            foreach(Kangelane heroiin in kangelased)
            {
                int arv = 100;
               
                Console.WriteLine(heroiin);

                Console.WriteLine($"Päästa tuleb {arv} inimest. \nPäästa suudeti {heroiin.Päästa(arv)} inimest. \n-----------");

            }
            Console.Beep(150, 150);

            Console.ReadKey();


            Console.WriteLine("TERE mAilM!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!\n!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
        }
    }
}
