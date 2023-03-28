﻿using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:BL is the entry for Saint Barthélemy in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization (ISO),
        /// which defines codes for the names of the principal subdivisions (e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently no ISO 3166-2 codes are defined in the entry for Saint Barthélemy.The territory has no defined subdivisions.
        /// Saint Barthélemy, an overseas territorial collectivity of France, is officially assigned the ISO 3166-1 alpha-2 code BL since 2007, after its secession from Guadeloupe.Moreover,
        /// it is also assigned the ISO 3166-2 code FR-BL under the entry for France.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:BL
        /// LastUpdated: 2023-03-26
        /// </remarks>
        internal static void ISO_3166_2_BL()
        {
            Debug.Assert(_subdivisionsPerCountry[Country.BL].Count == 0, "Number of subdivisions is wrong.");
        }
    }
}
