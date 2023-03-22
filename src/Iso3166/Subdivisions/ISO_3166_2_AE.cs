using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:AE is the entry for the United Arab Emirates in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization (ISO),
        /// which defines codes for the names of the principal subdivisions (e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for the United Arab Emirates, ISO 3166-2 codes are defined for 7 emirates.
        /// Each code consists of two parts, separated by a hyphen. The first part is AE, the ISO 3166-1 alpha-2 code of the United Arab Emirates. The second part is two letters.        
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:AE
        /// LastUpdated: 2023-03-20
        /// </remarks>
        internal static void ISO_3166_2_AE()
        {
            Add(Country.AE, "AJ", "‘Ajmān");
            Add(Country.AE, "AZ", "Abu Dhabi");
            Add(Country.AE, "FU", "Fujairah");
            Add(Country.AE, "SH", "Sharjah");
            Add(Country.AE, "DU", "Dubai");
            Add(Country.AE, "RK", "Ras Al Khaimah");
            Add(Country.AE, "UQ", "Umm Al Quwain");

            Debug.Assert(_subdivisionsPerCountry[Country.AE].Count == 7, "Number of subdivisions is wrong.");
        }
    }
}
