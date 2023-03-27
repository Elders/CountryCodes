using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:ZA is the entry for South Africa in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO),
        /// which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// ZA hails from Dutch: Zuid-Afrikaanse.Currently for South Africa, ISO 3166-2 codes are defined for 9 provinces.
        /// Each code consists of two parts, separated by a hyphen.The first part is ZA, the ISO 3166-1 alpha-2 code of South Africa.The second part consists of two or three letters indicating the province.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:ZA
        /// LastUpdated: 2023-03-21
        /// </remarks>
        internal static void ISO_3166_2_ZA()
        {
            Add(Country.ZA, "EC", "Eastern Cape");
            Add(Country.ZA, "FS", "Free State");
            Add(Country.ZA, "GP", "Gauteng");
            Add(Country.ZA, "KZN", "Kwazulu-Natal");
            Add(Country.ZA, "LP", "Limpopo");
            Add(Country.ZA, "MP", "Mpumalanga");
            Add(Country.ZA, "NW", "North-West");
            Add(Country.ZA, "NC", "Northern Cape");
            Add(Country.ZA, "WC", "Western Cape");

            Debug.Assert(_subdivisionsPerCountry[Country.ZA].Count == 9, "Number of subdivisions is wrong.");
        }
    }
}
