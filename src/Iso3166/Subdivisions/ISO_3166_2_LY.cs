using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:LY is the entry for Libya in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization (ISO),
        /// which defines codes for the names of the principal subdivisions (e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Libya, ISO 3166-2 codes are defined for 22 popularates.
        /// Each code consists of two parts, separated by a hyphen.The first part is LY, the ISO 3166-1 alpha-2 code of Libya.The second part is two letters.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:LY
        /// LastUpdated: 2023-03-24
        /// </remarks>
        internal static void ISO_3166_2_LY()
        {
            Add(Country.LY, "BU", "Al Buţnān");
            Add(Country.LY, "JA", "Al Jabal al Akhḑar");
            Add(Country.LY, "JG", "Al Jabal al Gharbī");
            Add(Country.LY, "JI", "Al Jafārah");
            Add(Country.LY, "JU", "Al Jufrah");
            Add(Country.LY, "KF", "Al Kufrah");
            Add(Country.LY, "MJ", "Al Marj");
            Add(Country.LY, "MB", "Al Marqab");
            Add(Country.LY, "WA", "Al Wāḩāt");
            Add(Country.LY, "NQ", "An Nuqāţ al Khams");
            Add(Country.LY, "ZA", "Az Zāwiyah");
            Add(Country.LY, "BA", "Banghāzī");
            Add(Country.LY, "DR", "Darnah");
            Add(Country.LY, "GT", "Ghāt");
            Add(Country.LY, "MI", "Mişrātah");
            Add(Country.LY, "MQ", "Murzuq");
            Add(Country.LY, "NL", "Nālūt");
            Add(Country.LY, "SB", "Sabhā");
            Add(Country.LY, "SR", "Surt");
            Add(Country.LY, "TB", "Ţarābulus");
            Add(Country.LY, "WD", "Wādī al Ḩayāt");
            Add(Country.LY, "WS", "Wādī ash Shāţi’");

            Debug.Assert(_subdivisionsPerCountry[Country.LY].Count == 22, $"{Country.LY} Number of subdivisions is wrong.");
        }
    }
}
