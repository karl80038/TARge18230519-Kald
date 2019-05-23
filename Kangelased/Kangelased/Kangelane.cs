using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kangelased
{
    class Kangelane
    {
        private string _Nimi;
        private string _Asukoht;

        public Kangelane(string Kangelase_nimi, string Kangelase_asukoht)
        {
            Nimi = Kangelase_nimi;
            Asukoht = Kangelase_asukoht;
        }

        public string Asukoht { get => _Asukoht; set => _Asukoht = value; }
        public string Nimi { get => _Nimi; set => _Nimi = value; }

        public virtual int Päästa (int Ohustatuid)
        {
            return (int)Math.Round(Ohustatuid * 0.95, 0);
        }

        public override string ToString()
        {
            return Nimi + " kaitseb " + Asukoht;
        }
    }
}
