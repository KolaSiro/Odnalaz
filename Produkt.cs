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
        public float Preis { get; set; }

        /// <summary>
        /// Produkte-Gruppe, z.B. Schuhe, Kleider
        /// </summary>
        public ProdukteGruppe Gruppe { get; set; }


        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="sName">Produktname</param>
        /// <param name="fPreis">Produktpreis</param>
        /// <param name="eGruppe">Produktegruppe</param>
        public Produkt(string sName, float fPreis, ProdukteGruppe eGruppe)
        {
            this.Name = sName;
            this.Preis = fPreis;
            this.Gruppe = eGruppe;
        }
    }
}