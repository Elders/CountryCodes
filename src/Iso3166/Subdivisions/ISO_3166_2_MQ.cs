﻿using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:MQ is the entry for Martinique in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization (ISO),
        /// which defines codes for the names of the principal subdivisions (e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently no ISO 3166-2 codes are defined in the entry for Martinique.
        /// Martinique, an overseas region/department of France, is officially assigned the ISO 3166-1 alpha-2 code MQ.Moreover,
        /// it is also assigned the ISO 3166-2 code FR-972 under the entry for France.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:MQ
        /// LastUpdated: 2023-03-26
        /// </remarks>
        internal static void ISO_3166_2_MQ()
        {
            Debug.Assert(_subdivisionsPerCountry.ContainsKey(Country.MQ) == false, $"{Country.MQ} Number of subdivisions is wrong.");
        }
    }
}
