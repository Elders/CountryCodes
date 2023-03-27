using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:BZ is the entry for Belize in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO),
        /// which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Belize, ISO 3166-2 codes are defined for 6 districts.
        /// Each code consists of two parts, separated by a hyphen.The first part is BZ, the ISO 3166-1 alpha-2 code of Belize.The second part is two or three letters.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:BZ
        /// LastUpdated: 2023-03-22
        /// </remarks>
        internal static void ISO_3166_2_BZ()
        {
            Add(Country.BZ, "BZ", "Belize");
            Add(Country.BZ, "CY", "Cayo");
            Add(Country.BZ, "CZL", "Corozal");
            Add(Country.BZ, "OW", "Orange Walk");
            Add(Country.BZ, "SC", "Stann Creek");
            Add(Country.BZ, "TOL", "Toledo");

            Debug.Assert(_subdivisionsPerCountry[Country.BZ].Count == 6, "Number of subdivisions is wrong.");
        }
    }
}
