﻿using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166 - 2:GG is the entry for Guernsey in ISO 3166 - 2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO),
        /// which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166 - 1.
        /// Currently no ISO 3166 - 2 codes are defined in the entry for Guernsey.
        /// Guernsey, a Crown dependency of the United Kingdom, is officially assigned the ISO 3166 - 1 alpha - 2 code GG since 2006.
        /// Previously it was assigned the ISO 3166 - 2 code GB - GSY under the entry for the United Kingdom.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:GG
        /// LastUpdated: 2023-03-26
        /// </remarks>
        internal static void ISO_3166_2_GG()
        {
            Debug.Assert(_subdivisionsPerCountry.ContainsKey(Country.GG) == false, $"{Country.GG} Number of subdivisions is wrong.");
        }
    }
}
