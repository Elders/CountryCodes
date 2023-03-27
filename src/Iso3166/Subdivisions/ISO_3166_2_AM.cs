using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:AM is the entry for Armenia in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization (ISO),
        /// which defines codes for the names of the principal subdivisions (e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Armenia, ISO 3166-2 codes are defined for 1 city and 10 regions.The city Yerevan is the capital of the country and has special status equal to the regions.
        /// Each code consists of two parts, separated by a hyphen.The first part is AM, the ISO 3166-1 alpha-2 code of Armenia.The second part is two letters.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:AM
        /// LastUpdated: 2023-03-22
        /// </remarks>
        internal static void ISO_3166_2_AM()
        {
            Add(Country.AM, "ER", "Yerevan");
            Add(Country.AM, "AG", "Aragatsotn");
            Add(Country.AM, "AR", "Ararat");
            Add(Country.AM, "AV", "Armavir");
            Add(Country.AM, "GR", "Gegharkunik");
            Add(Country.AM, "KT", "Kotayk");
            Add(Country.AM, "LO", "Lori");
            Add(Country.AM, "SH", "Shirak");
            Add(Country.AM, "SU", "Syunik");
            Add(Country.AM, "TV", "Tavush");
            Add(Country.AM, "VD", "Vayots Dzor");

            Debug.Assert(_subdivisionsPerCountry[Country.AM].Count == 11, "Number of subdivisions is wrong.");
        }
    }
}
