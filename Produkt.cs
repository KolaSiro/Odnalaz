using System;

namespace Odnalaz
{
    /// <summary>
    /// Basisklasse von allen Produkten
    /// </summary>
    public class Produkt
    {
        /// <summary>
        /// Name des Produkts
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Preis eines Produkts
        /// </summary>
        public float fPreis { get; set; }

        public float ePreis { get; set; }

        /// <summary>
        /// Produkte-Gruppe, z.B. Schuhe, Kleider
        /// </summary>
        public ProdukteGruppe Gruppe { get; set; }

        /// <summary>
        /// Produkte-Groesse: z.B. M, XL, oder 36, 41
        /// </summary>
        public string Groesse { get; set; }

        /// <summary>
        /// MwSt Mehrwertsteuersatz der Schweiz
        /// </summary>
        public float MwStSatz { get; set; }

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="sName">Produktname</param>
        /// <param name="fPreis">Produktpreis</param>
        /// <param name="eGruppe">Produktegruppe</param>
        /// <param name="sGroesse"Produktgroesse</param>
        public Produkt(string sName, float fPreis,float feuroPreis, ProdukteGruppe eGruppe, string sGroesse)
        {
            this.Name = sName;
            this.fPreis = fPreis;
            this.ePreis = (float)Math.Round(feuroPreis / 100 * 105, 2);
            this.Gruppe = eGruppe;
            this.Groesse = sGroesse;
            this.MwStSatz = 8.1f;
        }

    }
}