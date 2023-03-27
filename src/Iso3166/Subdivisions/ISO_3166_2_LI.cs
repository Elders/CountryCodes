using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:LI is the entry for Liechtenstein in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO),
        /// which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Liechtenstein, ISO 3166-2 codes are defined for 11 communes.
        /// Each code consists of two parts, separated by a hyphen.The first part is LI, the ISO 3166-1 alpha-2 code of Liechtenstein.The second part is two digits(01–11).
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:LI
        /// LastUpdated: 2023-03-24
        /// </remarks>
        internal static void ISO_3166_2_LI()
        {
            Add(Country.LI, "01", "Balzers");
            Add(Country.LI, "02", "Eschen");
            Add(Country.LI, "03", "Gamprin");
            Add(Country.LI, "04", "Mauren");
            Add(Country.LI, "05", "Planken");
            Add(Country.LI, "06", "Ruggell");
            Add(Country.LI, "07", "Schaan");
            Add(Country.LI, "08", "Schellenberg");
            Add(Country.LI, "09", "Triesen");
            Add(Country.LI, "10", "Triesenberg");
            Add(Country.LI, "11", "Vaduz");

            Debug.Assert(_subdivisionsPerCountry[Country.LI].Count == 11, "Number of subdivisions is wrong.");
        }
    }
}
