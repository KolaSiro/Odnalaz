using System;
using System.Collections.Generic;

namespace Odnalaz
{
    /// <summary>
    /// [S I M U L A T I O N]
    /// Odnalaz: Grosser, europaeischer online Kleider- und Schuhe Laden
    /// </summary>
    class TheStore
    {
        private static List<Produkt> produkte = new List<Produkt>();

        static void Main(string[] args)
        {
           
            // Lager füllen
            Lager();

            while(true)
            {
                switch(MenuAnzeigen())
                {
                    case "a":
                        LagerAnzeigen();
                        break;
                    case "e":
                        return;
                    default:
                        break;
                }
            }
        }

        static string MenuAnzeigen()
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("ODNALAZ: Online-Shopping");
            Console.WriteLine("------------------------");
            Console.WriteLine("Produkte anzeigen: a");
            Console.WriteLine("Programende:       e");

            string sEingang = Console.ReadLine();
            return sEingang.ToLower();
        }

        /// <summary>
        /// Lager mit Stammdaten befüllen.
        /// </summary>        
        private static void Lager()
        {                        
            produkte.Add( new Produkt() { Name = "Hose", Preis = 75f, Gruppe = ProdukteGruppe.BEKLEIDUNG }) ;
            produkte.Add(new Produkt() { Name = "T-Shirt", Preis = 45f, Gruppe = ProdukteGruppe.BEKLEIDUNG });
            produkte.Add(new Produkt() { Name = "Adidas Rom", Preis = 180.75f, Gruppe = ProdukteGruppe.SCHUHE });
        }

        /// <summary>
        /// Das komplette Lager anzeigen
        /// </summary>
        private static void LagerAnzeigen()
        {
            foreach (var p in produkte)
            {
                Console.WriteLine(p.Name + ", " + p.Preis + ", " + p.Gruppe);
            }
        }
    }
}
