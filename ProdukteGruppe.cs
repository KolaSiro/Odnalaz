using System;

namespace Odnalaz
{
    /// <summary>
    /// Produktegruppen List
    /// NONE = keiner Produktegruppe zugeordnet.
    /// BEKLEIDUNG = Hosen, TShirts
    /// </summary>
    [Flags]
    public enum ProdukteGruppe
    {
        NONE = 0, BEKLEIDUNG = 1, SCHUHE = 2, SCHMUCK = 4, BEAUTY = 8
    }
}