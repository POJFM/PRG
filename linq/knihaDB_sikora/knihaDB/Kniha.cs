namespace sikora
{
	internal class Kniha
	{
		private string titul, autorP, autorJ, vydavatel;
		private int vydano, pocetStran;
		public static string[] header = { "Název knihy", "Jméno Autora", "Přijmení autora", "Vydavatel", "Rok Vydání", "Počet Stran" };

		public string Titul { get => titul; set => titul = value; }
		public string AutorP { get => autorP; set => autorP = value; }
		public string AutorJ { get => autorJ; set => autorJ = value; }
		public string Vydavatel { get => vydavatel; set => vydavatel = value; }
		public int Vydano { get => vydano; set => vydano = value; }
		public int PocetStran { get => pocetStran; set => pocetStran = value; }

		public Kniha(string Titul, string AutorJmeno, string AutorPrijmeni, string Vydavatel, int Vydano, int PocetStran)
		{
			this.Titul = Titul;
			this.AutorP = AutorJmeno;
			this.AutorJ = AutorPrijmeni;
			this.Vydavatel = Vydavatel;
			this.Vydano = Vydano;
			this.PocetStran = PocetStran;
		}
	}
}