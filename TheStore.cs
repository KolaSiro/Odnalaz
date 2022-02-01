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
        /// <summary>
        /// Liste mit Produkten
        /// </summary>
        private static List<Produkt> produkte = new List<Produkt>();

        /// <summary>
        /// Haupteinstiegsfunktion
        /// </summary>
        /// <param name="args"></param>
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

        /// <summary>
        /// Hauptmenu anzeigen
        /// </summary>
        /// <returns></returns>
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
            produkte.Add(new Produkt("Hose", 75f, ProdukteGruppe.BEKLEIDUNG, "M"));
            produkte.Add(new Produkt("T-Shirt", 45f, ProdukteGruppe.BEKLEIDUNG, "S"));
            produkte.Add(new Produkt("Adidas Rom", 180.75f, ProdukteGruppe.SCHUHE, "42"));
            produkte.Add(new Produkt("Halskette Schmudlinsky", 550.00f, ProdukteGruppe.SCHMUCK, "kurz"));
            produkte.Add(new Produkt("Ohringe 2 Stk. silber", 175.80f, ProdukteGruppe.SCHMUCK, "3 cm"));
            produkte.Add(new Produkt("Vans", 50.0f, ProdukteGruppe.SCHUHE, "47"));
        }

        /// <summary>
        /// Das komplette Lager anzeigen
        /// </summary>
        private static void LagerAnzeigen()
        {
            Console.WriteLine("Filterung nach Produktegruppen");
            Console.WriteLine("Kleidung  : k");
            Console.WriteLine("Schuhe    : s");
            Console.WriteLine("Schmuck   : m");
            Console.WriteLine("Alle      : a");

            var sAuswahl = Console.ReadLine().ToLower().Trim();

            ProdukteGruppe grp = ProdukteGruppe.NONE;

            switch(sAuswahl)
            {
                case "k": grp = ProdukteGruppe.BEKLEIDUNG; break;
                case "s": grp = ProdukteGruppe.SCHUHE; break;
                case "m": grp = ProdukteGruppe.SCHMUCK; break;
                case "a": grp = ProdukteGruppe.NONE; break;
                default: break;
            }
                
            foreach (var p in produkte)
            {
                // Filterung nach Produktegruppe
                if ( p.Gruppe == grp || grp == ProdukteGruppe.NONE)
                {
                    Console.WriteLine(p.Name + ", " + p.Preis + ", " + p.Gruppe);
                }
            }

        }
    }
}
