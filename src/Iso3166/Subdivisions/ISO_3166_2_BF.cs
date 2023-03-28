using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:BF is the entry for Burkina Faso in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization (ISO), which defines codes for the names of the principal subdivisions (e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Burkina Faso, ISO 3166-2 codes are defined for two levels of subdivisions:
        ///     13 regions
        ///     45 provinces
        /// Each code consists of two parts, separated by a hyphen.The first part is BF, the ISO 3166-1 alpha-2 code of Burkina Faso. The second part is either of the following:
        ///     two digits (01–13): regions
        ///     three letters: provinces
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:BF
        /// LastUpdated: 2023-03-22
        /// </remarks>
        internal static void ISO_3166_2_BF()
        {
            Add(Country.BF, "01", "Boucle du Mouhoun");
            Add(Country.BF, "02", "Cascades");
            Add(Country.BF, "03", "Centre");
            Add(Country.BF, "04", "Centre-Est");
            Add(Country.BF, "05", "Centre-Nord");
            Add(Country.BF, "06", "Centre-Ouest");
            Add(Country.BF, "07", "Centre-Sud");
            Add(Country.BF, "08", "Est");
            Add(Country.BF, "09", "Hauts-Bassins");
            Add(Country.BF, "10", "Nord");
            Add(Country.BF, "11", "Plateau-Central");
            Add(Country.BF, "12", "Sahel");
            Add(Country.BF, "13", "Sud-Ouest");
            Add(Country.BF, "BAL", "Balé");
            Add(Country.BF, "BAM", "Bam");
            Add(Country.BF, "BAN", "Banwa");
            Add(Country.BF, "BAZ", "Bazèga");
            Add(Country.BF, "BGR", "Bougouriba");
            Add(Country.BF, "BLG", "Boulgou");
            Add(Country.BF, "BLK", "Boulkiemdé");
            Add(Country.BF, "COM", "Comoé");
            Add(Country.BF, "GAN", "Ganzourgou");
            Add(Country.BF, "GNA", "Gnagna");
            Add(Country.BF, "GOU", "Gourma");
            Add(Country.BF, "HOU", "Houet");
            Add(Country.BF, "IOB", "Ioba");
            Add(Country.BF, "KAD", "Kadiogo");
            Add(Country.BF, "KEN", "Kénédougou");
            Add(Country.BF, "KMD", "Komondjari");
            Add(Country.BF, "KMP", "Kompienga");
            Add(Country.BF, "KOS", "Kossi");
            Add(Country.BF, "KOP", "Koulpélogo");
            Add(Country.BF, "KOT", "Kouritenga");
            Add(Country.BF, "KOW", "Kourwéogo");
            Add(Country.BF, "LER", "Léraba");
            Add(Country.BF, "LOR", "Loroum");
            Add(Country.BF, "MOU", "Mouhoun");
            Add(Country.BF, "NAO", "Nahouri");
            Add(Country.BF, "NAM", "Namentenga");
            Add(Country.BF, "NAY", "Nayala");
            Add(Country.BF, "NOU", "Noumbiel");
            Add(Country.BF, "OUB", "Oubritenga");
            Add(Country.BF, "OUD", "Oudalan");
            Add(Country.BF, "PAS", "Passoré");
            Add(Country.BF, "PON", "Poni");
            Add(Country.BF, "SNG", "Sanguié");
            Add(Country.BF, "SMT", "Sanmatenga");
            Add(Country.BF, "SEN", "Séno");
            Add(Country.BF, "SIS", "Sissili");
            Add(Country.BF, "SOM", "Soum");
            Add(Country.BF, "SOR", "Sourou");
            Add(Country.BF, "TAP", "Tapoa");
            Add(Country.BF, "TUI", "Tuy");
            Add(Country.BF, "YAG", "Yagha");
            Add(Country.BF, "YAT", "Yatenga");
            Add(Country.BF, "ZIR", "Ziro");
            Add(Country.BF, "ZON", "Zondoma");
            Add(Country.BF, "ZOU", "Zoundwéogo");

            Debug.Assert(_subdivisionsPerCountry[Country.BF].Count == 58, $"{Country.BF} Number of subdivisions is wrong.");
        }
    }
}
