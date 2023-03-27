using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:FJ is the entry for Fiji in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization (ISO),
        /// which defines codes for the names of the principal subdivisions (e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Fiji, ISO 3166-2 codes are defined for 4 divisions, 1 dependency, and 14 provinces.
        /// Each code consists of two parts, separated by a hyphen.The first part is FJ,
        /// the ISO 3166-1 alpha-2 code of Fiji.The second part is a letter for divisions and dependency, and 2 digits for provinces.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:FJ
        /// LastUpdated: 2023-03-22
        /// </remarks>
        internal static void ISO_3166_2_FJ()
        {
            Add(Country.FJ, "C", "Central");
            Add(Country.FJ, "E", "Eastern");
            Add(Country.FJ, "N", "Northern");
            Add(Country.FJ, "W", "Western");
            Add(Country.FJ, "R", "Rotuma");
            Add(Country.FJ, "01", "Ba");
            Add(Country.FJ, "02", "Bua");
            Add(Country.FJ, "03", "Cakaudrove");
            Add(Country.FJ, "04", "Kadavu");
            Add(Country.FJ, "05", "Lau");
            Add(Country.FJ, "06", "Lomaiviti");
            Add(Country.FJ, "07", "Macuata");
            Add(Country.FJ, "08", "Nadroga and Navosa");
            Add(Country.FJ, "09", "Naitasiri");
            Add(Country.FJ, "10", "Namosi");
            Add(Country.FJ, "11", "Ra");
            Add(Country.FJ, "12", "Rewa");
            Add(Country.FJ, "13", "Serua");
            Add(Country.FJ, "14", "Tailevu");

            Debug.Assert(_subdivisionsPerCountry[Country.FJ].Count == 19, "Number of subdivisions is wrong.");
        }
    }
}
