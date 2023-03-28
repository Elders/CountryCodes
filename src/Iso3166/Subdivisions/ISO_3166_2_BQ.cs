using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:BQ is the entry for Bonaire, Sint Eustatius and Saba in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO),
        /// which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Bonaire, Sint Eustatius and Saba, special municipalities of the Netherlands, ISO 3166-2 codes are defined for 3 special municipalities.
        /// Each code consists of two parts, separated by a hyphen. The first part is BQ, the ISO 3166-1 alpha-2 code of Bonaire, Sint Eustatius and Saba. The second part is two letters.
        /// Each special municipality is also assigned their own ISO 3166-2 code under the entry for the Netherlands.[1]
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:BQ
        /// LastUpdated: 2023-03-22
        /// </remarks>
        internal static void ISO_3166_2_BQ()
        {
            Add(Country.BQ, "BO", "Bonaire");
            Add(Country.BQ, "SA", "Saba");
            Add(Country.BQ, "SE", "Sint Eustatius");

            Debug.Assert(_subdivisionsPerCountry[Country.BQ].Count == 3, $"{Country.BQ} Number of subdivisions is wrong.");
        }
    }
}
