using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:AT is the entry for Austria in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization (ISO),
        /// which defines codes for the names of the principal subdivisions (e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Austria, ISO 3166-2 codes are defined for 9 states.
        /// Each code consists of two parts, separated by a hyphen.The first part is AT, the ISO 3166-1 alpha-2 code of Austria.The second part is a digit(1–9).
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:AT
        /// LastUpdated: 2023-03-22
        /// </remarks>
        internal static void ISO_3166_2_AT()
        {
            Add(Country.AT, "1", "Burgenland");
            Add(Country.AT, "2", "Carinthia");
            Add(Country.AT, "3", "Lower Austria");
            Add(Country.AT, "4", "Upper Austria");
            Add(Country.AT, "5", "Salzburg");
            Add(Country.AT, "6", "Styria");
            Add(Country.AT, "7", "Tyrol");
            Add(Country.AT, "8", "Vorarlberg");
            Add(Country.AT, "9", "Vienna");

            Debug.Assert(_subdivisionsPerCountry[Country.AT].Count == 9, "Number of subdivisions is wrong.");
        }
    }
}
