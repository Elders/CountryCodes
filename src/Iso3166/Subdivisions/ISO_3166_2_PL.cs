using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:PL is the entry for Poland in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO),
        /// which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Poland, ISO 3166-2 codes are defined for 16 voivodeships.
        /// Each code consists of two parts, separated by a hyphen.The first part is PL, the ISO 3166-1 alpha-2 code of Poland.The second part is two digits.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:PL
        /// LastUpdated: 2023-03-21
        /// </remarks>
        internal static void ISO_3166_2_PL()
        {
            Add(Country.PL, "02", "Lower Silesia");
            Add(Country.PL, "04", "Kuyavia-Pomerania");
            Add(Country.PL, "06", "Lublin");
            Add(Country.PL, "08", "Lubusz");
            Add(Country.PL, "10", "Łódź");
            Add(Country.PL, "12", "Lesser Poland");
            Add(Country.PL, "14", "Mazovia");
            Add(Country.PL, "16", "Opole");
            Add(Country.PL, "18", "Subcarpathia");
            Add(Country.PL, "20", "Podlaskie");
            Add(Country.PL, "22", "Pomerania");
            Add(Country.PL, "24", "Silesia");
            Add(Country.PL, "26", "Holy Cross");
            Add(Country.PL, "28", "Warmia-Masuria");
            Add(Country.PL, "30", "Greater Poland");
            Add(Country.PL, "32", "West Pomerania");

            Debug.Assert(_subdivisionsPerCountry[Country.PL].Count == 16, "Number of subdivisions is wrong.");
        }
    }
}
