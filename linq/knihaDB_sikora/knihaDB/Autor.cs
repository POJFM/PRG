namespace sikora
{
	internal class Autor
	{
		private string jmeno, prijmeni;
		private int rokNarozeni, rokUmrti;
		public static string[] header = { "Jméno", "Přijmení", "Rok Narození", "Rok Úmrtí" };

		public string Jmeno { get => jmeno; set => jmeno = value; }
		public string Prijmeni { get => prijmeni; set => prijmeni = value; }
		public int RokNarozeni { get => rokNarozeni; set => rokNarozeni = value; }
		public int RokUmrti { get => rokUmrti; set => rokUmrti = value; }

		public Autor(string Jmeno, string Prijmeni, int RokNarozeni, int RokUmrti)
		{
			this.Jmeno = Jmeno;
			this.Prijmeni = Prijmeni;
			this.RokNarozeni = RokNarozeni;
			this.RokUmrti = RokUmrti;
		}
	}
}