using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:KM is the entry for the Comoros in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization (ISO),
        /// which defines codes for the names of the principal subdivisions (e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for the Comoros, ISO 3166-2 codes are defined for 3 islands.
        /// Each code consists of two parts, separated by a hyphen.The first part is KM, the ISO 3166-1 alpha-2 code of the Comoros.The second part is a letter.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:KM
        /// LastUpdated: 2023-03-24
        /// </remarks>
        internal static void ISO_3166_2_KM()
        {
            Add(Country.KM, "G", "Grande Comore");
            Add(Country.KM, "A", "Anjouan");
            Add(Country.KM, "M", "Mohéli");

            Debug.Assert(_subdivisionsPerCountry[Country.KM].Count == 3, $"{Country.KM} Number of subdivisions is wrong.");
        }
    }
}
