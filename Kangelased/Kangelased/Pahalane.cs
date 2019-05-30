using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kangelased
{
    class Pahalane : Kangelane
    {
        public Pahalane (string Nimi, string Asukoht) : base(Nimi, Asukoht)
        {

        }

        public override int Päästa(int Ohustatuid)
        {
            return 0;
        }

        public override string ToString()
        {
            return Nimi + " ohustab  " + Asukoht;
        }


    }
}
