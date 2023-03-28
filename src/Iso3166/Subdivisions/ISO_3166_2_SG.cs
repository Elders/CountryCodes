using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:SG is the entry for Singapore in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO),
        /// which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Singapore, ISO 3166-2 codes are defined for 5 districts.
        /// Each code consists of two parts, separated by a hyphen.The first part is SG, the ISO 3166-1 alpha-2 code of Singapore.The second part is two digits(01–05).
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:SG
        /// LastUpdated: 2023-03-21
        /// </remarks>
        internal static void ISO_3166_2_SG()
        {
            Add(Country.SG, "01", "Central Singapore");
            Add(Country.SG, "02", "North East");
            Add(Country.SG, "03", "North West");
            Add(Country.SG, "04", "South East");
            Add(Country.SG, "05", "South West");

            Debug.Assert(_subdivisionsPerCountry[Country.SG].Count == 5, $"{Country.SG} Number of subdivisions is wrong.");
        }
    }
}
