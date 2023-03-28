using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:TV is the entry for Tuvalu in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO),
        /// which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Tuvalu, ISO 3166-2 codes are defined for 1 town council and 7 island councils.Niulakita, which now has its own island council,
        /// is not listed as it is administered as part of Niutao.
        /// Each code consists of two parts, separated by a hyphen. The first part is TV, the ISO 3166-1 alpha-2 code of Tuvalu.The second part is three letters.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:TV
        /// LastUpdated: 2023-03-20
        /// </remarks>
        internal static void ISO_3166_2_TV()
        {
            Add(Country.TV, "FUN", "Funafuti");
            Add(Country.TV, "NMG", "Nanumaga");
            Add(Country.TV, "NMA", "Nanumea");
            Add(Country.TV, "NIT", "Niutao");
            Add(Country.TV, "NUI", "Nui");
            Add(Country.TV, "NKF", "Nukufetau");
            Add(Country.TV, "NKL", "Nukulaelae");
            Add(Country.TV, "VAI", "Vaitupu");

            Debug.Assert(_subdivisionsPerCountry[Country.TV].Count == 8, $"{Country.TV} Number of subdivisions is wrong.");
        }
    }
}
