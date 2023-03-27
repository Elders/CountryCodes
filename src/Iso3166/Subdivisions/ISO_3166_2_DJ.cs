using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:DJ is the entry for Djibouti in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization (ISO),
        /// which defines codes for the names of the principal subdivisions (e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Djibouti, ISO 3166-2 codes are defined for 5 regions and 1 city.The city Djibouti is the capital of the country and has special status equal to the regions.
        /// Each code consists of two parts, separated by a hyphen.The first part is DJ, the ISO 3166-1 alpha-2 code of Djibouti.The second part is two letters.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:DJ
        /// LastUpdated: 2023-03-22
        /// </remarks>
        internal static void ISO_3166_2_DJ()
        {
            Add(Country.DJ, "AS", "Ali Sabieh");
            Add(Country.DJ, "AR", "Arta");
            Add(Country.DJ, "DI", "Dikhil");
            Add(Country.DJ, "OB", "Obock");
            Add(Country.DJ, "TA", "Tadjourah");
            Add(Country.DJ, "DJ", "Djibouti");

            Debug.Assert(_subdivisionsPerCountry[Country.DJ].Count == 6, "Number of subdivisions is wrong.");
        }
    }
}
