using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:UZ is the entry for Uzbekistan in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization (ISO),
        /// which defines codes for the names of the principal subdivisions (e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Uzbekistan, ISO 3166-2 codes are defined for 1 city, 12 regions, and 1 republic. The city Tashkent is the capital of the country and has special status equal to the regions.
        /// Each code consists of two parts, separated by a hyphen. The first part is UZ, the ISO 3166-1 alpha-2 code of Uzbekistan. The second part is two letters.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:UZ
        /// LastUpdated: 2023-03-20
        /// </remarks>
        internal static void ISO_3166_2_UZ()
        {
            Add(Country.UZ, "TK", "Toshkent");
            Add(Country.UZ, "AN", "Andijon");
            Add(Country.UZ, "BU", "Buxoro");
            Add(Country.UZ, "FA", "Farg‘ona");
            Add(Country.UZ, "JI", "Jizzax");
            Add(Country.UZ, "NG", "Namangan");
            Add(Country.UZ, "NW", "Navoiy");
            Add(Country.UZ, "QA", "Qashqadaryo");
            Add(Country.UZ, "SA", "Samarqand");
            Add(Country.UZ, "SI", "Sirdaryo");
            Add(Country.UZ, "SU", "Surxondaryo");
            Add(Country.UZ, "TO", "Toshkent");
            Add(Country.UZ, "XO", "Xorazm");
            Add(Country.UZ, "QR", "Qoraqalpog‘iston Respublikasi");

            Debug.Assert(_subdivisionsPerCountry[Country.UZ].Count == 14, $"{Country.UZ} Number of subdivisions is wrong.");
        }
    }
}
