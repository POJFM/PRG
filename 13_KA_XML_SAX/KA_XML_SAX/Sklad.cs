using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KA_XML_SAX
{
    class Sklad
    {
        string nazevZbozi;
        int pocetKs, id;
        double cenaKs;
        DateTime expirace;

        //Vlastnosti
        public string NazevZbozi { get => nazevZbozi; set => nazevZbozi = value; }
        public int PocetKs { get => pocetKs; set => pocetKs = value; }
        public DateTime Expirace { get => expirace; set => expirace = value; }
        public int Id { get => id; set => id = value; }
        public double CenaKs { get => cenaKs; set => cenaKs = value; }

        //konstruktor
        public Sklad(int id, string nazevZbozi, int pocetKs, double cenaKs, DateTime expirace)
        {
            Id = id;
            NazevZbozi = nazevZbozi;
            PocetKs = pocetKs;
            CenaKs = cenaKs;
            Expirace = expirace;
        }
        public override string ToString()
        {
            return Id + " " + NazevZbozi + "  " + PocetKs + " " + CenaKs + "  " + Expirace;
        }
    }
}
