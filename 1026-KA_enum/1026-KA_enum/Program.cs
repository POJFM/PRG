using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _1026_KA_enum.Uchazeci;

namespace _1026_KA_enum
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Uchazeci> uchazeci = new List<Uchazeci>();
            uchazeci.Add(new Uchazeci("Petr", "Novák", 26, gender.muz, colorHair.hneda, colorEyes.hneda));
            uchazeci.Add(new Uchazeci("Adam", "Rychlý", 25, gender.muz, colorHair.blond, colorEyes.modra));
            uchazeci.Add(new Uchazeci("Markéta", "Cibulová", 19, gender.zena, colorHair.cerna, colorEyes.zelena));
            uchazeci.Add(new Uchazeci("Veronika", "Zátopová", 18, gender.zena, colorHair.hneda, colorEyes.modra));
            uchazeci.Add(new Uchazeci("Nikol", "Zárubová", 21, gender.zena, colorHair.blond, colorEyes.modra));
            uchazeci.Add(new Uchazeci("Bronislava", "Perníčková", 24, gender.zena, colorHair.hneda, colorEyes.modrozelena));
            uchazeci.Add(new Uchazeci("Jakub", "Novák", 18, gender.muz, colorHair.rezava, colorEyes.seda));
            uchazeci.Add(new Uchazeci("Petr", "Novák", 26, gender.muz, colorHair.hneda, colorEyes.hneda));
            uchazeci.Add(new Uchazeci("Tomáš", "Zelený", 21, gender.muz, colorHair.cerna, colorEyes.hneda));
            uchazeci.Add(new Uchazeci("Vojtěch", "Rampa", 19, gender.muz, colorHair.nezadano, colorEyes.modroseda));

            foreach(var i in uchazeci)
            {
                i.Print();
            }

            Console.WriteLine("========================================================");

            /*List<int> duplikaty = new List<int>();
            foreach(var i in uchazeci)
            {
                for(int j = uchazeci.IndexOf(i) + 1; j < uchazeci.Count; j++)
                {
                    if(i.Equals(j))
                    {
                        duplikaty.Add(uchazeci.IndexOf(i));
                    }
                }
            }*/

            Console.ReadKey();
        }
    }
}
