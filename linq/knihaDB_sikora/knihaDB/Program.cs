using System;
using System.Collections.Generic;

namespace sikora
{
	internal static class Program
	{
		private static void Main(string[] args)
		{
			// Nastavení velikosti okna aby se vlezly tabulky
			Console.SetWindowSize(130, 32);

			// Knihy
			List<Kniha> knihy = new List<Kniha>()
			{
				new Kniha("Kocourkov", "Sekora", "Ondřej", "Albatros", 1940, 200),
				new Kniha("Dekameron", "Boccaccio", "Giovanni", "Odeon", 1975, 600),
				new Kniha("Průmysl", "Novák", "Milan", "Albatros", 1960, 400),
				new Kniha("Nestřídmost", "Savojský", "Tomáš", "Odeon", 1975, 1500),
				new Kniha("Lakomství", "Novákovský", "Emil", "Nakladatel", 1755, 354)
			};

			// Autoři
			List<Autor> autori = new List<Autor>()
			{
				new Autor("Onřej", "Sekora", 1899, 1967),
				new Autor("Giovanni", "Boccaccio", 1313, 1375),
				new Autor("Milan", "Novák", 1941, 1990),
				new Autor("Adam", "Novák", 1841, 1915),
				new Autor("Tomáš", "Savojský", 1951, 2008)
			};

			// Úvod programu
			DB.Uvod();

			// Hlaví loop programu
			bool cont = true;
			while (cont)
			{
				string[] input = DB.Input().Split(' ');
				switch(input[0])
				{
					// Zobrazte prvky obou kolekcí
					case "list":
						try
						{
							if (input[1] == "knihy")
								DB.PrintKnihy(knihy, "", "");
							else if (input[1] == "autori")
								DB.PrintAutori(autori, "", "");
						}
						catch
						{
							DB.PrintKnihy(knihy, "", "");
							DB.PrintAutori(autori, "", "");
						}
						break;
					// Nový autor nebo kniha
					case "new":
						try
						{
							if (input[1] == "autor")
								DB.NewAutor(autori);
							else if (input[1] == "kniha")
								DB.NewKniha(knihy);
						}
						catch
						{
							Console.WriteLine("Nový \"autor\" nebo \"kniha\"?");
							string newInput = DB.Input();
							if (newInput == "autor")
								DB.NewAutor(autori);
							else if (newInput == "kniha")
								DB.NewKniha(knihy);
							else
								DB.SyntaxError();
						}
						break;
					// Seřaďte kolekci
					case "seradit":
						try
						{
							int input3 = int.Parse(input[3]);
							if (input[1] == "autory" && input[2] == "podle")
							{
								try
								{
									string input4 = input[4];
									if (input3 > 0 && input3 <= 4 && input4 == "reverse")
										DB.OrderAutor(input3, autori, input4);
									else
										DB.SyntaxError();
								}
								catch
								{
									if (input3 > 0 && input3 <= 4)
										DB.OrderAutor(input3, autori, "");
									else
										DB.SyntaxError();
								}
							}
							else if (input[1] == "knihy" && input[2] == "podle")
							{
								try
								{
									string input4 = input[4];
									if (input3 > 0 && input3 <= 6 && input4 == "reverse")
										DB.OrderKniha(input3, knihy, input4);
									else
										DB.SyntaxError();
								}
								catch
								{
									if (input3 > 0 && input3 <= 4)
										DB.OrderKniha(input3, knihy, "");
									else
										DB.SyntaxError();
								}
							}
							else
								DB.SyntaxError();
						}
						catch
						{
							DB.SyntaxError();
						}
						break;
					// Zobrazte jen některé prvky
					case "filtrovat":
						try
						{
							int input3 = int.Parse(input[3]); // číslo sloupce
							string input5 = input[5]; // klíčové slovo vetsi/mensi nebo filtr sloupce (napr. "Čapek" zobrazí pouze autory s příjmení "Čapek")
							if (input[1] == "autory" && input[2] == "kde")
							{
								if (input3 > 0 && input3 <= 4)
								{
									if (input5 == "vetsi" || input5 == "mensi")
									{
										try
										{
											int input7 = int.Parse(input[7]); // operand = vetsi/mensi nez input7
											DB.FilterAutorVetsiMensi(autori, input3, input5, input7);
										}
										catch
										{
											DB.SyntaxError();
										}
									}
									else
										DB.FilterAutor(autori, input3, input5);
								}
							}
							else if (input[1] == "knihy" && input[2] == "kde")
							{
								if (input3 > 0 && input3 <= 6)
								{
									if (input5 == "vetsi" || input5 == "mensi")
									{
										try
										{
											int input7 = int.Parse(input[7]); // operand = vetsi/mensi nez input7
											DB.FilterKnihaVetsiMensi(knihy, input3, input5, input7);
										}
										catch
										{
											DB.SyntaxError();
										}
									}
									else
										DB.FilterKniha(knihy, input3, input5);
								}
							}
							else
								DB.SyntaxError();
						}
						catch
						{
							DB.SyntaxError();
						}
						break;
					// Propojte obě kolekce pomocí seskupení
					case "join":
						DB.Join(autori, knihy);
						break;
					case "help":
						DB.PrintHelp();
						break;
					case "clear":
						Console.Clear();
						break;
					case "q":
						DB.Exit();
						break;
					default:
						DB.SyntaxError();
						break;
				}
			}
		}
	}
}