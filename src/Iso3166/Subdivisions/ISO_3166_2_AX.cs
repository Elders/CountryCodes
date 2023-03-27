using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:AX is the entry for the Åland Islands in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization (ISO),
        /// which defines codes for the names of the principal subdivisions (e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently no ISO 3166-2 codes are defined in the entry for the Åland Islands.
        /// Åland, an autonomous region of Finland(also a former province), is officially assigned the ISO 3166-1 alpha-2 code AX since 2004 (see ISO 3166-1 Newsletter V-9).
        /// Moreover, it is also assigned the ISO 3166-2 code FI-01 under the entry for Finland.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:AX
        /// LastUpdated: 2023-03-26
        /// </remarks>
        internal static void ISO_3166_2_AX()
        {
            Debug.Assert(_subdivisionsPerCountry[Country.AX].Count == 0, "Number of subdivisions is wrong.");
        }
    }
}
