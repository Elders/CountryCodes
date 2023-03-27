using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:SZ is the entry for Eswatini in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization (ISO),
        /// which defines codes for the names of the principal subdivisions (e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Eswatini, ISO 3166-2 codes are defined for the four regions of Eswatini.
        /// Each code consists of two parts, separated by a hyphen.The first part is SZ, the ISO 3166-1 alpha-2 code of Eswatini.The second part is two letters.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:SZ
        /// LastUpdated: 2023-03-22
        /// </remarks>
        internal static void ISO_3166_2_SZ()
        {
            Add(Country.SZ, "HH", "Hhohho");
            Add(Country.SZ, "LU", "Lubombo");
            Add(Country.SZ, "MA", "Manzini");
            Add(Country.SZ, "SH", "Shiselweni");

            Debug.Assert(_subdivisionsPerCountry[Country.SZ].Count == 4, "Number of subdivisions is wrong.");
        }
    }
}
