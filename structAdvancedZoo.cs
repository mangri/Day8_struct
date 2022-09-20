using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace structAdvancedZoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Gyvunas> sarasas = new List<Gyvunas>();
            Gyvunas gyvunas1 = new Gyvunas("Dumelis", "Seskunas");
            Gyvunas gyvunas2 = new Gyvunas("Mamba", "Kobrine");
            Gyvunas gyvunas3 = new Gyvunas("Geluonis", "Kobrine");
            sarasas.Add(gyvunas1);
            sarasas.Add(gyvunas2);
            sarasas.Add(gyvunas3);
            Zoo zoo1 = new Zoo("Timbuktu", "Skripalio bulvaras", sarasas);
            (int kiek, int kiekRusiu) = zooStat(zoo1.Sarasas);
            Console.WriteLine("Zoologijos sodas {0} esantis adresu {1} \n" +
                "turi {2} rusiu gyvunu, viso gyvunu: {3}", 
                zoo1.Pavadinimas, zoo1.Adresas, kiekRusiu, kiek);

        }
        struct Gyvunas
        {
            public string Vardas;
            public string Rusis;
            public Gyvunas(string vardas, string rusis)
            {
                Vardas = vardas;
                Rusis = rusis;
            }
        }
        struct Zoo
        {
            public string Pavadinimas;
            public string Adresas;
            public List<Gyvunas> Sarasas;
            public Zoo(string pavadinimas, string adresas, List<Gyvunas> sarasas)
            {
                Pavadinimas = pavadinimas;
                Adresas = adresas;
                Sarasas = sarasas;
            }
        }
        static (int, int) zooStat(List<Gyvunas> sarasas)
        {
            int kiek = sarasas.Count;
            List<string> rusisList = new List<string>();
            foreach (Gyvunas gyv in sarasas)
            {
                rusisList.Add(gyv.Rusis);
            }
            int kiekRusiu = rusisList.Distinct().Count();
            return (kiek, kiekRusiu);
        }
    }
}
