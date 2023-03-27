using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:LR is the entry for Liberia in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization (ISO),
        /// which defines codes for the names of the principal subdivisions (e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Liberia, ISO 3166-2 codes are defined for 15 counties.
        /// Each code consists of two parts, separated by a hyphen.The first part is LR,
        /// the ISO 3166-1 alpha-2 code of Liberia.The second part is two letters.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:LR
        /// LastUpdated: 2023-03-24
        /// </remarks>
        internal static void ISO_3166_2_LR()
        {
            Add(Country.LR, "BM", "Bomi");
            Add(Country.LR, "BG", "Bong");
            Add(Country.LR, "GP", "Gbarpolu");
            Add(Country.LR, "GB", "Grand Bassa");
            Add(Country.LR, "CM", "Grand Cape Mount");
            Add(Country.LR, "GG", "Grand Gedeh");
            Add(Country.LR, "GK", "Grand Kru");
            Add(Country.LR, "LO", "Lofa");
            Add(Country.LR, "MG", "Margibi");
            Add(Country.LR, "MY", "Maryland");
            Add(Country.LR, "MO", "Montserrado");
            Add(Country.LR, "NI", "Nimba");
            Add(Country.LR, "RI", "River Cess");
            Add(Country.LR, "RG", "River Gee");
            Add(Country.LR, "SI", "Sinoe");

            Debug.Assert(_subdivisionsPerCountry[Country.LR].Count == 15, "Number of subdivisions is wrong.");
        }
    }
}
