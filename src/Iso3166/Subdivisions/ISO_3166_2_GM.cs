using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:GM is the entry for the Gambia in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization (ISO),
        /// which defines codes for the names of the principal subdivisions (e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for the Gambia, ISO 3166-2 codes are defined for 1 city and 5 divisions.The city Banjul is the capital of the country and has special status equal to the divisions.
        /// Each code consists of two parts, separated by a hyphen.The first part is GM, the ISO 3166-1 alpha-2 code of the Gambia.The second part is a letter.
        /// The code for Central River is from its former name, MacCarthy Island.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:GM
        /// LastUpdated: 2023-03-22
        /// </remarks>
        internal static void ISO_3166_2_GM()
        {
            Add(Country.GM, "B", "Banjul");
            Add(Country.GM, "M", "Central River");
            Add(Country.GM, "L", "Lower River");
            Add(Country.GM, "N", "North Bank");
            Add(Country.GM, "U", "Upper River");
            Add(Country.GM, "W", "Western");

            Debug.Assert(_subdivisionsPerCountry[Country.GM].Count == 6, "Number of subdivisions is wrong.");
        }
    }
}
