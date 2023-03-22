using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:MN is the entry for Mongolia in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization (ISO), which defines codes for the names of the principal subdivisions (e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Mongolia, ISO 3166-2 codes are defined for 1 capital city and 21 provinces.The capital of the country Ulaanbaatar has special status equal to the provinces.
        /// Each code consists of two parts, separated by a hyphen.The first part is MN, the ISO 3166-1 alpha-2 code of Mongolia.The second part is either of the following:
        ///     one digit: capital city
        ///     three digits: provinces
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:MN
        /// LastUpdated: 2023-03-22
        /// </remarks>
        internal static void ISO_3166_2_MN()
        {
            Add(Country.MN, "1", "Ulaanbaatar");
            Add(Country.MN, "073", "Arhangay");
            Add(Country.MN, "069", "Bayanhongor");
            Add(Country.MN, "071", "Bayan-Ölgiy");
            Add(Country.MN, "067", "Bulgan");
            Add(Country.MN, "037", "Darhan uul");
            Add(Country.MN, "061", "Dornod");
            Add(Country.MN, "063", "Dornogovĭ");
            Add(Country.MN, "059", "Dundgovĭ");
            Add(Country.MN, "057", "Dzavhan");
            Add(Country.MN, "065", "Govĭ-Altay");
            Add(Country.MN, "064", "Govĭ-Sümber");
            Add(Country.MN, "039", "Hentiy");
            Add(Country.MN, "043", "Hovd");
            Add(Country.MN, "041", "Hövsgöl");
            Add(Country.MN, "053", "Ömnögovĭ");
            Add(Country.MN, "035", "Orhon");
            Add(Country.MN, "055", "Övörhangay");
            Add(Country.MN, "049", "Selenge");
            Add(Country.MN, "051", "Sühbaatar");
            Add(Country.MN, "047", "Töv");
            Add(Country.MN, "046", "Uvs");

            Debug.Assert(_subdivisionsPerCountry[Country.MN].Count == 22, "Number of subdivisions is wrong.");
        }
    }
}
