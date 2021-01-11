using System;
using System.Collections.Generic;
using System.Linq;

namespace sikora
{
	internal static class DB
	{
		static string[] usage = {
									"help",
									"clear",
									"q",
									"list [autori|knihy]",
									"new  [autor|kniha]",
									"seradit [autory|knihy] podle [1|2|3|4|5|6] [reverse]",
									"filtrovat [autory|knihy] kde [1|2|3|4|5|6] je [string|int]",
									"filtrovat [autory|knihy] kde [1|2|3|4|5|6] je [vetsi|mensi] nez [int]",
									"join"
								};
		static string[] description = {
										"zobrazí nápovědu",
										"resetuje konzolové okno",
										"ukončí program",
										"vypíše autory nebo knihy nebo obojí",
										"vytvoří nového autora nebo knihu",
										"seřadí autory nebo knihy podle sloupce (reverse naopak)",
										"filtruje autory nebo knihy kde sloupec musí obsahovat string nebo int",
										"filtruje autory nebo knihy kde sloupec musí být větší nebo menší než int",
										"propojení obou kolekcí pomocí seskupení"
									  };

		public static void Color()
		{
			Console.ForegroundColor = ConsoleColor.Gray;
		}

		public static void PrintBlue(string s)
		{
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.Write(s);
			Color();
		}

		public static string Input()
		{
			PrintBlue(">> ");
			return Console.ReadLine();
		}

		public static void Uvod()
		{
			PrintBlue(  "        __ __       _ __          ____  ____  \n" +
						"       / //_/____  (_) /_  ____ _/ __ \\/ __ ) \n" +
						"      / ,<  / __ \\/ / __ \\/ __ `/ / / / __  | \n" +
						"     / /| |/ / / / / / / / /_/ / /_/ / /_/ /  \n" +
						"    /_/ |_/_/ /_/_/_/ /_/\\__,_/_____/_____/   \n" +
						"                (c) Filip Sikora              \n" +
						" \n");
			Console.WriteLine(	$"{usage[0]} => {description[0]}\n" +
								$"{usage[1]} => {description[1]}\n" +
								$"{usage[2]} => {description[2]}\n" +
								$"{usage[3]} => {description[3]}\n" +
								$"{usage[4]} => {description[4]}\n" +
								$"{usage[5]} => {description[5]}\n" +
								$"{usage[6]} => {description[6]}\n" +
								$"{usage[7]} => {description[7]}\n" +
								$"{usage[8]} => {description[8]}\n" +
								" ");
		}

		public static void Error(string err)
		{
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine(err);
			Color();
		}

		public static void SyntaxError()
		{
			Error("Syntax error. Use command \"help\" for usage.");
		}

		public static void PrintHelp()
		{
			Table.PrintLine();
			for (int i = 0; i < usage.Length; i++)
			{
				PrintBlue(usage[i]);
				Console.WriteLine($"\n{description[i]}");
				Table.PrintLine();
			}
		}

		public static void Exit()
		{
			Environment.Exit(0);
			/* Nedodělané - uložit do CSV
			Console.Write("Uložit? [y/n]: ");
			string input = Console.ReadLine();
			if (input == "y" | input == "")
			{
				// uložit do CSV
				Environment.Exit(0);
			}
			else if(input == "n")
				Environment.Exit(0);
			else
			{
				Error("Odpovězte pouze \"y\" pro ano nebo \"n\" pro ne.");
				Exit();
			}*/
		}

		public static int TryInt(string column)
		{
			try
			{
				PrintBlue($"{column}: ");
				return int.Parse(Console.ReadLine());
			}
			catch
			{
				Error($"{column} musí být celé číslo!");
				return TryInt(column);
			}
		}
		// Propojte obě kolekce pomocí seskupení
		public static void Join(List<Autor> autori, List<Kniha> knihy)
		{
			var joined = from i in knihy
						 join j in autori
						 on i.AutorP equals j.Prijmeni
						 select new { i.AutorP, i.AutorJ, j.Prijmeni, j.Jmeno };
			Table.PrintRow("Příjmení [Autori]", "Jméno [Autori]", "Příjmení [Knihy]", "Jméno [Knihy]");
			foreach (var j in joined)
			{
				Console.WriteLine($"|{Table.AlignCenter(j.AutorP, 29)}" +
								  $"|{Table.AlignCenter(j.AutorJ, 29)}" +
								  $"|{Table.AlignCenter(j.Prijmeni, 29)}" +
								  $"|{Table.AlignCenter(j.Jmeno, 29)}|");
			}
			Table.PrintLine();
		}

		public static void PrintKnihy(List<Kniha> knihy, string column, string query)
		{
			Console.WriteLine($"[ KNIHY{column}{query} ]");
			Table.PrintRow(Kniha.header);
			foreach (var kniha in knihy)
			{
				Console.WriteLine($"|{Table.AlignCenter(kniha.Titul, 19)}" +
								  $"|{Table.AlignCenter(kniha.AutorJ, 19)}" +
								  $"|{Table.AlignCenter(kniha.AutorP, 19)}" +
								  $"|{Table.AlignCenter(kniha.Vydavatel, 19)}" +
								  $"|{Table.AlignCenter(kniha.Vydano.ToString(), 19)}" +
								  $"|{Table.AlignCenter(kniha.PocetStran.ToString(), 19)}|");
			}
			Table.PrintLine();
		}

		public static void NewKniha(List<Kniha> knihy)
		{
			PrintBlue("Titul: ");
			string titul = Console.ReadLine();
			PrintBlue("Jméno autora: ");
			string autorJ = Console.ReadLine();
			PrintBlue("Příjemní autora: ");
			string autorP = Console.ReadLine();
			PrintBlue("Vydavatel: ");
			string vydavatel = Console.ReadLine();
			int vydano = TryInt("Rok Vydání");
			int pocetStran = TryInt("Počet stran");
			knihy.Add(new Kniha(titul, autorJ, autorP, vydavatel, vydano, pocetStran));
		}

		public static void OrderKniha(int column, List<Kniha> knihy, string input4)
		{
			if (input4 == "reverse")
			{
				switch (column)
				{
					case 1:
						knihy = knihy.OrderBy(a => a.Titul).Select(a => a).Reverse().ToList();
						PrintKnihy(knihy, "Titulu", " REVERSE");
						break;
					case 2:
						knihy = knihy.OrderBy(a => a.AutorJ).Select(a => a).Reverse().ToList();
						PrintKnihy(knihy, "Jména Autora", " REVERSE");
						break;
					case 3:
						knihy = knihy.OrderBy(a => a.AutorP).Select(a => a).Reverse().ToList();
						PrintKnihy(knihy, "Příjmení autora", " REVERSE");
						break;
					case 4:
						knihy = knihy.OrderBy(a => a.Vydavatel).Select(a => a).Reverse().ToList();
						PrintKnihy(knihy, "Vydavatele", " REVERSE");
						break;
					case 5:
						knihy = knihy.OrderBy(a => a.Vydano).Select(a => a).Reverse().ToList();
						PrintKnihy(knihy, "Roku Vydání", " REVERSE");
						break;
					case 6:
						knihy = knihy.OrderBy(a => a.PocetStran).Select(a => a).Reverse().ToList();
						PrintKnihy(knihy, "Počtu Stran", " REVERSE");
						break;
					default:
						SyntaxError();
						break;
				}
			}
			else
			{
				switch (column)
				{
					case 1:
						knihy = knihy.OrderBy(a => a.Titul).Select(a => a).ToList();
						PrintKnihy(knihy, " podle Titulu", "");
						break;
					case 2:
						knihy = knihy.OrderBy(a => a.AutorJ).Select(a => a).ToList();
						PrintKnihy(knihy, " podle Jména Autora", "");
						break;
					case 3:
						knihy = knihy.OrderBy(a => a.AutorP).Select(a => a).ToList();
						PrintKnihy(knihy, " podle Příjmení autora", "");
						break;
					case 4:
						knihy = knihy.OrderBy(a => a.Vydavatel).Select(a => a).ToList();
						PrintKnihy(knihy, " podle Vydavatele", "");
						break;
					case 5:
						knihy = knihy.OrderBy(a => a.Vydano).Select(a => a).ToList();
						PrintKnihy(knihy, " podle Roku Vydání", "");
						break;
					case 6:
						knihy = knihy.OrderBy(a => a.PocetStran).Select(a => a).ToList();
						PrintKnihy(knihy, " podle Počtu Stran", "");
						break;
					default:
						SyntaxError();
						break;
				}
			}
		}

		public static void FilterKniha(List<Kniha> knihy, int column, string input)
		{
			List<Kniha> FilteredKniha = new List<Kniha>();
			switch (column)
			{
				case 1:
					foreach (var kniha in from kniha in knihy
										  where kniha.Titul == input
										  select new { kniha.Titul, kniha.AutorJ, kniha.AutorP, kniha.Vydavatel, kniha.Vydano, kniha.PocetStran })
					{
						FilteredKniha.Add(new Kniha(kniha.Titul, kniha.AutorJ, kniha.AutorP, kniha.Vydavatel, kniha.Vydano, kniha.PocetStran));
					}
					knihy = FilteredKniha;
					PrintKnihy(knihy, $" Titul je ", input);
					break;
				case 2:
					foreach (var kniha in from kniha in knihy
										  where kniha.AutorJ == input
										  select new { kniha.Titul, kniha.AutorJ, kniha.AutorP, kniha.Vydavatel, kniha.Vydano, kniha.PocetStran })
					{
						FilteredKniha.Add(new Kniha(kniha.Titul, kniha.AutorJ, kniha.AutorP, kniha.Vydavatel, kniha.Vydano, kniha.PocetStran));
					}
					knihy = FilteredKniha;
					PrintKnihy(knihy, $" Jméno Autora je ", input);
					break;
				case 3:
					foreach (var kniha in from kniha in knihy
										  where kniha.AutorP == input
										  select new { kniha.Titul, kniha.AutorJ, kniha.AutorP, kniha.Vydavatel, kniha.Vydano, kniha.PocetStran })
					{
						FilteredKniha.Add(new Kniha(kniha.Titul, kniha.AutorJ, kniha.AutorP, kniha.Vydavatel, kniha.Vydano, kniha.PocetStran));
					}
					knihy = FilteredKniha;
					PrintKnihy(knihy, $" Příjmení Autora je ", input);
					break;
				case 4:
					foreach (var kniha in from kniha in knihy
										  where kniha.Vydavatel == input
										  select new { kniha.Titul, kniha.AutorJ, kniha.AutorP, kniha.Vydavatel, kniha.Vydano, kniha.PocetStran })
					{
						FilteredKniha.Add(new Kniha(kniha.Titul, kniha.AutorJ, kniha.AutorP, kniha.Vydavatel, kniha.Vydano, kniha.PocetStran));
					}
					knihy = FilteredKniha;
					PrintKnihy(knihy, $" Vydavatel je ", input);
					break;
				case 5:
					try
					{
						int _input = int.Parse(input);
						foreach (var kniha in from kniha in knihy
											  where kniha.Vydano == _input
											  select new { kniha.Titul, kniha.AutorJ, kniha.AutorP, kniha.Vydavatel, kniha.Vydano, kniha.PocetStran })
						{
							FilteredKniha.Add(new Kniha(kniha.Titul, kniha.AutorJ, kniha.AutorP, kniha.Vydavatel, kniha.Vydano, kniha.PocetStran));
						}
						knihy = FilteredKniha;
						PrintKnihy(knihy, $" Vydáno je ", input);
					}
					catch
					{
						SyntaxError();
					}
					break;
				case 6:
					try
					{
						int _input = int.Parse(input);
						foreach (var kniha in from kniha in knihy
											  where kniha.PocetStran == _input
											  select new { kniha.Titul, kniha.AutorJ, kniha.AutorP, kniha.Vydavatel, kniha.Vydano, kniha.PocetStran })
						{
							FilteredKniha.Add(new Kniha(kniha.Titul, kniha.AutorJ, kniha.AutorP, kniha.Vydavatel, kniha.Vydano, kniha.PocetStran));
						}
						knihy = FilteredKniha;
						PrintKnihy(knihy, $" Počet Stran je ", input);
					}
					catch
					{
						SyntaxError();
					}
					break;
			}
		}

		public static void FilterKnihaVetsiMensi(List<Kniha> knihy, int column, string keyword, int operand)
		{
			List<Kniha> FilteredKniha = new List<Kniha>();
			if (column > 4 && column <= 6)
			{
				if (column == 5)
				{
					if (keyword == "mensi")
					{
						foreach (var kniha in from kniha in knihy
											  where kniha.Vydano < operand
											  select new { kniha.Titul, kniha.AutorJ, kniha.AutorP, kniha.Vydavatel, kniha.Vydano, kniha.PocetStran })
						{
							FilteredKniha.Add(new Kniha(kniha.Titul, kniha.AutorJ, kniha.AutorP, kniha.Vydavatel, kniha.Vydano, kniha.PocetStran));
						}
						knihy = FilteredKniha;
						PrintKnihy(knihy, $" Rok Vydání {keyword} než ", operand.ToString());
					}
					else if (keyword == "vetsi")
					{
						foreach (var kniha in from kniha in knihy
											  where kniha.Vydano > operand
											  select new { kniha.Titul, kniha.AutorJ, kniha.AutorP, kniha.Vydavatel, kniha.Vydano, kniha.PocetStran })
						{
							FilteredKniha.Add(new Kniha(kniha.Titul, kniha.AutorJ, kniha.AutorP, kniha.Vydavatel, kniha.Vydano, kniha.PocetStran));
						}
						knihy = FilteredKniha;
						PrintKnihy(knihy, $" Rok Narození {keyword} než ", operand.ToString());
					}
				}
				else if (column == 6)
				{
					if (keyword == "mensi")
					{
						foreach (var kniha in from kniha in knihy
											  where kniha.PocetStran < operand
											  select new { kniha.Titul, kniha.AutorJ, kniha.AutorP, kniha.Vydavatel, kniha.Vydano, kniha.PocetStran })
						{
							FilteredKniha.Add(new Kniha(kniha.Titul, kniha.AutorJ, kniha.AutorP, kniha.Vydavatel, kniha.Vydano, kniha.PocetStran));
						}
						knihy = FilteredKniha;
						PrintKnihy(knihy, $" Rok Úmrtí {keyword} než ", operand.ToString());
					}
					else if (keyword == "vetsi")
					{
						foreach (var kniha in from kniha in knihy
											  where kniha.PocetStran > operand
											  select new { kniha.Titul, kniha.AutorJ, kniha.AutorP, kniha.Vydavatel, kniha.Vydano, kniha.PocetStran })
						{
							FilteredKniha.Add(new Kniha(kniha.Titul, kniha.AutorJ, kniha.AutorP, kniha.Vydavatel, kniha.Vydano, kniha.PocetStran));
						}
						knihy = FilteredKniha;
						PrintKnihy(knihy, $" Rok Úmrtí {keyword} než ", operand.ToString());
					}
				}

			}
			else
			{
				Error("Filtrovat lze pouze podle polí s datovým typem INT.");
			}
		}

		public static void PrintAutori(List<Autor> autori, string column, string query)
		{
			Console.WriteLine($"[ AUTORI{column}{query} ]");
			Table.PrintRow("Jméno", "Přijmení", "Rok Narození", "Rok Úmrtí");
			foreach (var autor in autori)
			{
				Console.WriteLine($"|{Table.AlignCenter(autor.Jmeno, 29)}" +
								  $"|{Table.AlignCenter(autor.Prijmeni, 29)}" +
								  $"|{Table.AlignCenter(autor.RokNarozeni.ToString(), 29)}" +
								  $"|{Table.AlignCenter(autor.RokUmrti.ToString(), 29)}|");
			}
			Table.PrintLine();
		}

		public static void NewAutor(List<Autor> autori)
		{
			PrintBlue("Jméno: ");
			string jmeno = Console.ReadLine();
			PrintBlue("Příjmení: ");
			string prijmeni = Console.ReadLine();
			int rokNarozeni = TryInt("Rok Narození");
			int rokUmrti = TryInt("Rok Úmrtí");
			autori.Add(new Autor(jmeno, prijmeni, rokNarozeni, rokUmrti));
		}

		public static void OrderAutor(int column, List<Autor> autori, string input4)
		{
			if (input4 == "reverse")
			{
				switch (column)
				{
					case 1:
						autori = autori.OrderBy(a => a.Jmeno).Select(a => a).Reverse().ToList();
						PrintAutori(autori, " podle Jména", " REVERSE");
						break;
					case 2:
						autori = autori.OrderBy(a => a.Prijmeni).Select(a => a).Reverse().ToList();
						PrintAutori(autori, " podle Příjmení", " REVERSE");
						break;
					case 3:
						autori = autori.OrderBy(a => a.RokNarozeni).Select(a => a).Reverse().ToList();
						PrintAutori(autori, " podle Roku Narození", " REVERSE");
						break;
					case 4:
						autori = autori.OrderBy(a => a.RokUmrti).Select(a => a).Reverse().ToList();
						PrintAutori(autori, " podle Roku Úmrtí", " REVERSE");
						break;
					default:
						SyntaxError();
						break;
				}
			}
			else
			{
				switch (column)
				{
					case 1:
						autori = autori.OrderBy(a => a.Jmeno).Select(a => a).ToList();
						PrintAutori(autori, " podle Jména", "");
						break;
					case 2:
						autori = autori.OrderBy(a => a.Prijmeni).Select(a => a).ToList();
						PrintAutori(autori, " podle Příjmení", "");
						break;
					case 3:
						autori = autori.OrderBy(a => a.RokNarozeni).Select(a => a).ToList();
						PrintAutori(autori, "Roku Narození", "");
						break;
					case 4:
						autori = autori.OrderBy(a => a.RokUmrti).Select(a => a).ToList();
						PrintAutori(autori, "Roku Úmrtí", "");
						break;
					default:
						SyntaxError();
						break;
				}
			}
		}

		public static void FilterAutor(List<Autor> autori, int column, string input)
		{
			List<Autor> FilteredAutor = new List<Autor>();
			switch (column)
			{
				case 1:
					foreach (var autor in from autor in autori
										  where autor.Jmeno == input
										  select new { autor.Jmeno, autor.Prijmeni, autor.RokNarozeni, autor.RokUmrti })
					{
						FilteredAutor.Add(new Autor(autor.Jmeno, autor.Prijmeni, autor.RokNarozeni, autor.RokUmrti));
					}
					autori = FilteredAutor;
					PrintAutori(autori, $" Jméno je ", input);
					break;
				case 2:
					foreach (var autor in from autor in autori
										  where autor.Prijmeni == input
										  select new { autor.Jmeno, autor.Prijmeni, autor.RokNarozeni, autor.RokUmrti })
					{
						FilteredAutor.Add(new Autor(autor.Jmeno, autor.Prijmeni, autor.RokNarozeni, autor.RokUmrti));
					}
					autori = FilteredAutor;
					PrintAutori(autori, $" Příjmení je ", input);
					break;
				case 3:
					try
					{
						int _input = int.Parse(input);
						foreach (var autor in from autor in autori
											  where autor.RokNarozeni == _input
											  select new { autor.Jmeno, autor.Prijmeni, autor.RokNarozeni, autor.RokUmrti })
						{
							FilteredAutor.Add(new Autor(autor.Jmeno, autor.Prijmeni, autor.RokNarozeni, autor.RokUmrti));
						}
						autori = FilteredAutor;
						PrintAutori(autori, $" Rok Narození je ", input);
					}
					catch
					{
						SyntaxError();
					}
					break;
				case 4:
					try
					{
						int _input = int.Parse(input);
						foreach (var autor in from autor in autori
											  where autor.RokUmrti == _input
											  select new { autor.Jmeno, autor.Prijmeni, autor.RokNarozeni, autor.RokUmrti })
						{
							FilteredAutor.Add(new Autor(autor.Jmeno, autor.Prijmeni, autor.RokNarozeni, autor.RokUmrti));
						}
						autori = FilteredAutor;
						PrintAutori(autori, $" Rok Úmrtí je ", input);
					}
					catch
					{
						SyntaxError();
					}
					break;
			}
		}

		public static void FilterAutorVetsiMensi(List<Autor> autori, int column, string keyword, int operand)
		{
			List<Autor> FilteredAutor = new List<Autor>();
			if (column > 2 && column <= 4)
			{
				if (column == 3)
				{
					if (keyword == "mensi")
					{
						foreach (var autor in from autor in autori
											  where autor.RokNarozeni < operand
											  select new { autor.Jmeno, autor.Prijmeni, autor.RokNarozeni, autor.RokUmrti })
						{
							FilteredAutor.Add(new Autor(autor.Jmeno, autor.Prijmeni, autor.RokNarozeni, autor.RokUmrti));
						}
						autori = FilteredAutor;
						PrintAutori(autori, $" Rok Narození {keyword} než ", operand.ToString());
					}
					else if (keyword == "vetsi")
					{
						foreach (var autor in from autor in autori
											  where autor.RokNarozeni > operand
											  select new { autor.Jmeno, autor.Prijmeni, autor.RokNarozeni, autor.RokUmrti })
						{
							FilteredAutor.Add(new Autor(autor.Jmeno, autor.Prijmeni, autor.RokNarozeni, autor.RokUmrti));
						}
						autori = FilteredAutor;
						PrintAutori(autori, $" Rok Narození {keyword} než ", operand.ToString());
					}
				}
				else if (column == 4)
				{
					if (keyword == "mensi")
					{
						foreach (var autor in from autor in autori
											  where autor.RokUmrti < operand
											  select new { autor.Jmeno, autor.Prijmeni, autor.RokNarozeni, autor.RokUmrti })
						{
							FilteredAutor.Add(new Autor(autor.Jmeno, autor.Prijmeni, autor.RokNarozeni, autor.RokUmrti));
						}
						autori = FilteredAutor;
						PrintAutori(autori, $" Rok Úmrtí {keyword} než ", operand.ToString());
					}
					else if (keyword == "vetsi")
					{
						foreach (var autor in from autor in autori
											  where autor.RokUmrti > operand
											  select new { autor.Jmeno, autor.Prijmeni, autor.RokNarozeni, autor.RokUmrti })
						{
							FilteredAutor.Add(new Autor(autor.Jmeno, autor.Prijmeni, autor.RokNarozeni, autor.RokUmrti));
						}
						autori = FilteredAutor;
						PrintAutori(autori, $" Rok Úmrtí {keyword} než ", operand.ToString());
					}
				}
				
			}
			else
			{
				Error("Filtrovat lze pouze podle polí s datovým typem INT.");
			}
		}
	}
}