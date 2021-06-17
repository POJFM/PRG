using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sikora_xml
{
	public class Kniha
	{
		private string titul, autorP, autorJ, vydavatel;
		private int vydano, pocetStran;

		public string Titul { get => titul; set => titul = value; }
		public string AutorJ { get => autorJ; set => autorJ = value; }
		public string AutorP { get => autorP; set => autorP = value; }
		public string Vydavatel { get => vydavatel; set => vydavatel = value; }
		public int Vydano { get => vydano; set => vydano = value; }
		public int PocetStran { get => pocetStran; set => pocetStran = value; }

		public Kniha(string Titul, string AutorJmeno, string AutorPrijmeni, string Vydavatel, int Vydano, int PocetStran)
		{
			this.Titul = Titul;
			this.AutorJ = AutorJmeno;
			this.AutorP = AutorPrijmeni;
			this.Vydavatel = Vydavatel;
			this.Vydano = Vydano;
			this.PocetStran = PocetStran;
		}
	}
}
