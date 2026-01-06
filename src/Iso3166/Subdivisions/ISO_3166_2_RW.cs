using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:RW is the entry for Rwanda in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO),
        /// which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Rwanda, ISO 3166-2 codes are defined for 1 city and 4 provinces.The city Kigali is the capital of the country and has special status equal to the provinces.
        /// Each code consists of two parts, separated by a hyphen.The first part is RW, the ISO 3166-1 alpha-2 code of Rwanda.The second part is two digits:
        ///     01: city
        ///     02–05: provinces
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:RW
        /// LastUpdated: 2023-03-21
        /// </remarks>
        internal static void ISO_3166_2_RW()
        {
            Add(Country.RW, "01", "City of Kigali");
            Add(Country.RW, "02", "Eastern");
            Add(Country.RW, "03", "Northern");
            Add(Country.RW, "04", "Western");
            Add(Country.RW, "05", "Southern");

            Debug.Assert(_subdivisionsPerCountry[Country.RW].Count == 5, $"{Country.RW} Number of subdivisions is wrong.");
        }
    }
}
