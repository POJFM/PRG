using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static KA_vala_enum.uchazeci;

namespace KA_vala_enum
{
	class Program
	{
		static void Main(string[] args)
		{
			List<uchazeci> uchazec = new List<uchazeci>();
			uchazec.Add(new uchazeci("Jan", "Novák", gender.muz, 18, eyeColor.hneda, hairColor.hneda));
			uchazec.Add(new uchazeci("Jan", "Novák", gender.muz, 18, eyeColor.hneda, hairColor.hneda));
			uchazec.Add(new uchazeci("Petr", "Novotný", gender.muz, 18, eyeColor.zelena, hairColor.blond));
			uchazec.Add(new uchazeci("Jakub", "Vantuch", gender.muz, 20, eyeColor.modroseda, hairColor.rezava));
			uchazec.Add(new uchazeci("Ondřej", "Jelínek", gender.muz, 23, eyeColor.modrozelena, hairColor.cerna));
			uchazec.Add(new uchazeci("Klárka", "Nová", gender.zena, 19, eyeColor.seda, hairColor.blond));
			uchazec.Add(new uchazeci("Eliška", "Pokorná", gender.zena, 25, eyeColor.modra, hairColor.hneda));
			uchazec.Add(new uchazeci("Lili", "Světlá", gender.zena, 30, eyeColor.modra, hairColor.blond));
			uchazec.Add(new uchazeci("Petr", "Karásek", gender.muz, 28, eyeColor.modroseda, hairColor.cerna));
			uchazec.Add(new uchazeci("Daniel", "Vávra", gender.muz, 20, eyeColor.nezadano, hairColor.nezadano));

			//print all of dem
			foreach (var individual in uchazec)
			{
				individual.Print();
			}
			Console.WriteLine("************************************************");


			//filter those bad bois
			/*List<uchazeci> withDupes = uchazec;
			List<uchazeci> noDupes = withDupes.Distinct().ToList();
			foreach(var indivindi in noDupes)
			{
				indivindi.Print();
			}*/
			//well tohle mělo fungovat

			List<uchazeci> uchazecNoDupes = new List<uchazeci>();
			/*for (int i = 0; i < uchazec.Count; i++) //ITERATE thru all records
			{
				if (uchazec[i].Equals(uchazec[i + 1]))
				{
					uchazecNoDupes.Add(uchazec[i]);
					while (uchazec[i].Equals(uchazec[i + 1]))
					{
						i++;
					}
				}
			}*/
			//print them
			foreach (var individuum in uchazecNoDupes)
			{
				individuum.Print();
			}


			Console.ReadKey();
		}

		
	}
}
