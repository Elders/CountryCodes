using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:TO is the entry for Tonga in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization (ISO),
        /// which defines codes for the names of the principal subdivisions (e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Tonga, ISO 3166-2 codes are defined for 5 divisions.Each code consists of two parts, separated by a hyphen.The first part is TO,
        /// the ISO 3166-1 alpha-2 code of Tonga.The second part is two digits(01–05).
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:TO
        /// LastUpdated: 2023-03-20
        /// </remarks>
        internal static void ISO_3166_2_TO()
        {
            Add(Country.TO, "01", "'Eua");
            Add(Country.TO, "02", "Ha'apai");
            Add(Country.TO, "03", "Niuas");
            Add(Country.TO, "04", "Tongatapu");
            Add(Country.TO, "05", "Vava'u");

            Debug.Assert(_subdivisionsPerCountry[Country.TO].Count == 5, "Number of subdivisions is wrong.");
        }
    }
}
