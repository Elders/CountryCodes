using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:VC is the entry for Saint Vincent and the Grenadines in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO), which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Saint Vincent and the Grenadines, ISO 3166-2 codes are defined for 6 parishes.
        /// Each code consists of two parts, separated by a hyphen.The first part is VC, the ISO 3166-1 alpha-2 code of Saint Vincent and the Grenadines.The second part is two digits:
        ///     01–05: parishes on the island of Saint Vincent
        ///     06: parish in the northern part of the Grenadines
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:VC
        /// LastUpdated: 2023-03-21
        /// </remarks>
        internal static void ISO_3166_2_VC()
        {
            Add(Country.VC, "01", "Charlotte");
            Add(Country.VC, "02", "Saint Andrew");
            Add(Country.VC, "03", "Saint David");
            Add(Country.VC, "04", "Saint George");
            Add(Country.VC, "05", "Saint Patrick");
            Add(Country.VC, "06", "Grenadines");

            Debug.Assert(_subdivisionsPerCountry[Country.VC].Count == 6, $"{Country.VC} Number of subdivisions is wrong.");
        }
    }
}
