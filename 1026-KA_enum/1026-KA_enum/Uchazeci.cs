using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1026_KA_enum
{
    class Uchazeci
    {
        public enum gender
        {
            muz,
            zena
        };
        public enum colorHair
        {
            nezadano,
            blond,
            hneda,
            cerna,
            rezava
        };
        [Flags]
        public enum colorEyes
        {
            nezadano,
            modra,
            zelena,
            hneda,
            seda,
            modrozelena = modra | zelena,
            modroseda = modra | seda
        };

        private string jmeno;
        private string prijmeni;
        private int vek;
        private gender pohlavi;
        private colorHair barvaVlasu;
        private colorEyes barvaOci;

        public string Jmeno { get => jmeno; set => jmeno = value; }
        public string Prijmeni { get => prijmeni; set => prijmeni = value; }
        public int Vek { get => vek; set => vek = value; }
        public gender Pohlavi { get => pohlavi; set => pohlavi = value; }
        public colorHair BarvaVlasu { get => barvaVlasu; set => barvaVlasu = value; }
        public colorEyes BarvaOci { get => barvaOci; set => barvaOci = value; }

        public Uchazeci(string jmeno, string prijmeni, int vek, gender pohlavi, colorHair barvaVlasu, colorEyes barvaOci)
        {
            this.jmeno = jmeno;
            this.prijmeni = prijmeni;
            this.vek = vek;
            this.pohlavi = pohlavi;
            this.barvaVlasu = barvaVlasu;
            this.barvaOci = barvaOci;
        }

        public override bool Equals(object obj)
        {
            if (obj is Uchazeci)
            {
                Uchazeci details = (Uchazeci)obj;
                return details.jmeno == this.jmeno && details.prijmeni == this.prijmeni;
            }
            return false;
        }

        public void Print()
        {
            Console.WriteLine("Jméno: " + this.jmeno);
            Console.WriteLine("Příjmení: " + this.prijmeni);
            Console.WriteLine("Věk: " + this.vek);
            Console.WriteLine("Pohlaví: " + this.pohlavi);
            Console.WriteLine("Barva vlasů: " + this.barvaVlasu);
            Console.WriteLine("Barva očí: " + this.barvaOci);
            Console.WriteLine("--------------------------------------------");
        }
    }
}
