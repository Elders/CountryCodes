using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:SL is the entry for Sierra Leone in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO),
        /// which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Sierra Leone, ISO 3166-2 codes are defined for 1 area and 4 provinces.The Western Area contains the capital of the country Freetown and has special status equal to the provinces.
        /// Each code consists of two parts, separated by a hyphen. The first part is SL, the ISO 3166-1 alpha-2 code of Sierra Leone. The second part is 1 or 2 letters.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:SL
        /// LastUpdated: 2023-03-21
        /// </remarks>
        internal static void ISO_3166_2_SL()
        {
            Add(Country.SL, "E", "Eastern");
            Add(Country.SL, "NW", "North Western");
            Add(Country.SL, "N", "Northern");
            Add(Country.SL, "S", "Southern");
            Add(Country.SL, "W", "Western Area");

            Debug.Assert(_subdivisionsPerCountry[Country.SL].Count == 5, $"{Country.SL} Number of subdivisions is wrong.");
        }
    }
}
