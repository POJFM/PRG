using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml; //musíme připojit XML

namespace KA_XML_SAX
{
    class Program
    {
        static void Main(string[] args)
        {
            // zápis do XML pomoci SAX 🍆🍆🍆

            // kolekce pro zapis
            List<Sklad> skladWrite = new List<Sklad>();
            // přidáme obsah do kolekce pro zapis
            skladWrite.Add(new Sklad(0, "Pantofle", 25, 419.99, new DateTime(2020, 2, 12)));
            skladWrite.Add(new Sklad(1, "Bačkory", 45, 420, new DateTime(2020, 3, 2)));
            skladWrite.Add(new Sklad(2, "Sandále", 66, 68.99, new DateTime(2020, 1, 21)));

            //nastavení writeru resp značek pro odsazení
            XmlWriterSettings nastaveni = new XmlWriterSettings();
            nastaveni.Indent = true;

            // zapsat XML
            writeFile(skladWrite, nastaveni);
            // přečíst XML
            List<Sklad> sklad = readFile("pokus.xml");
            
            //výpis načtených prvků kolekce
            Console.WriteLine("ID \t Celé jméno \t Věk \t Registrován");
            foreach (Sklad s in sklad)
            {
                Console.WriteLine(s.ToString());
            }
            Console.ReadLine();
        }

        static void writeFile(List<Sklad> sklad, XmlWriterSettings config)
        {
            using (XmlWriter zapis = XmlWriter.Create(@"pokus.xml", config))
            {
                //hlavička souboru resp začátek dokumentu
                zapis.WriteStartDocument();
                //otevřeme kořenový element
                zapis.WriteStartElement("sklad");
                //zapis jednotlivých elementů, procházím dcelou kolekci
                foreach (Sklad s in sklad)
                {
                    zapis.WriteStartElement("produkt"); // začátek zápisu
                    zapis.WriteAttributeString("ID", s.Id.ToString()); // ID je atributem
                    zapis.WriteElementString("nazevZbozi", s.NazevZbozi);
                    zapis.WriteElementString("pocetKs", s.PocetKs.ToString());
                    zapis.WriteElementString("cenaKs", s.CenaKs.ToString());
                    zapis.WriteElementString("expirace", s.Expirace.ToShortDateString());
                    zapis.WriteEndElement(); // konec zápisu

                }
                zapis.WriteEndElement();
                zapis.WriteEndDocument(); // ukončení celého dokumentu
                zapis.Flush();

            }
        }

        static List<Sklad> readFile(string path)
        {
            List <Sklad> sklad = new List<Sklad>();
            using (XmlReader reader = XmlReader.Create(@path))
            {
                // nadeklarujeme proměnné pro uložení vlastností
                int id = 0;
                string nazevZbozi = "";
                int pocetKs = 0;
                double cenaKs = 0;
                DateTime expirace = DateTime.Now; // nastavení aktualniho datumu for fun

                while (reader.Read()) {
                    //čteme po uzlech (počáteční element, koncový element, text)
                    if (reader.NodeType == XmlNodeType.Element)
                    {
                        if (reader.Name == "produkt")
                            id = int.Parse(reader.GetAttribute("ID"));
                        else if (reader.Name == "nazevZbozi")
                            nazevZbozi = reader.ReadInnerXml();
                        else if (reader.Name == "pocetKs")
                            pocetKs = int.Parse(reader.ReadInnerXml());
                        else if (reader.Name == "cenaKs")
                            cenaKs = double.Parse(reader.ReadInnerXml());
                        else if (reader.Name == "expirace")
                            expirace = DateTime.Parse(reader.ReadInnerXml());
                    }
                    // načtení konce elementu přečetli jsme jednoho uživatele
                    if (reader.NodeType == XmlNodeType.EndElement && reader.Name == "produkt")
                        sklad.Add(new Sklad(id, nazevZbozi, pocetKs, cenaKs, expirace));
                    // načtení konce elementu přečetli jsme všechny uživatele
                    if (reader.NodeType == XmlNodeType.EndElement && reader.Name == "sklad")
                        reader.Close();
                }
            }
            return sklad;
        }
    }
}
