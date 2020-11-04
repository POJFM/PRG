using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KA_vala_enum
{
	public class uchazeci
	{
		public enum gender
		{
			muz,
			zena
		};

		public enum hairColor
		{
			nezadano,
			blond,
			hneda,
			cerna,
			rezava
		};
	
		[Flags]
		public enum eyeColor
		{
			nezadano,
			modra,
			zelena,
			hneda,
			seda,
			modrozelena = modra | zelena,
			modroseda = modra | seda
		};

		private string prijmeni;
		private int vek;
		private eyeColor barvaOci;
		private gender pohlavi;
		private hairColor barvaVlasu;
		private string jmeno;

		public string Jmeno { get => jmeno; set => jmeno = value; }
		public string Prijmeni { get => prijmeni; set => prijmeni = value; }
		public int Vek { get => vek; set => vek = value; }
		public eyeColor BarvaOci { get => barvaOci; set => barvaOci = value; }
		public gender Pohlavi { get => pohlavi; set => pohlavi = value; }
		public hairColor BarvaVlasu { get => barvaVlasu; set => barvaVlasu = value; }

		public uchazeci(string jmeno, string prijmeni, gender pohlavi, int vek, eyeColor barvaOci, hairColor barvaVlasu)
		{
			this.jmeno = jmeno;
			this.prijmeni = prijmeni;
			this.pohlavi = pohlavi;
			this.vek = vek;
			this.barvaOci = barvaOci;
			this.barvaVlasu = barvaVlasu;
		}

		public void Print()
		{
			Console.WriteLine("Jméno: " + this.jmeno);
			Console.WriteLine("Příjmení: " + this.prijmeni);
			Console.WriteLine("Pohlaví: " + this.pohlavi);
			Console.WriteLine("Věk: " + this.vek);
			Console.WriteLine("Barva očí: " + this.barvaOci);
			Console.WriteLine("Barva vlasů: " + this.barvaVlasu);
			Console.WriteLine("___________________________________");
		}

		public override bool Equals(object obj)
		{
			return ((obj is uchazeci) && (this == (uchazeci)obj));
		}
		public static bool operator == (uchazeci u1, uchazeci u2)
		{
			return ((u1.jmeno == u2.jmeno) && (u1.prijmeni == u2.prijmeni) && (u1.pohlavi == u2.pohlavi) && (u1.vek == u2.vek) && (u1.barvaOci == u2.barvaOci) && (u1.barvaVlasu == u2.barvaVlasu));
		}
		public static bool operator != (uchazeci u1, uchazeci u2)
		{
			return !(u1 == u2);
		}
		public override int GetHashCode()
		{
			return jmeno.GetHashCode() ^ prijmeni.GetHashCode() ^ pohlavi.GetHashCode() ^ vek.GetHashCode() ^ barvaOci.GetHashCode() ^ barvaVlasu.GetHashCode();
		}
	}
}

