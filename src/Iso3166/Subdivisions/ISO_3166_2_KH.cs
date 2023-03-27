using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:KH is the entry for Cambodia in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO),
        /// which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Cambodia, ISO 3166-2 codes are defined for 1 autonomous municipality and 24 provinces.
        /// Each code consists of two parts, separated by a hyphen.The first part is KH, the ISO 3166-1 alpha-2 code of Cambodia.The second part is a number.
        ///     The digits are currently used in postal codes, except for codes 1-9, for which one must include 0 before the number (1 becomes 01) to get the postal code from the ISO code:
        ///     1–21: autonomous municipalities and provinces as of late 1980s
        ///     22–25: autonomous municipalities and province created since the 1990s
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:KH
        /// LastUpdated: 2023-03-24
        /// </remarks>
        internal static void ISO_3166_2_KH()
        {
            Add(Country.KH, "1", "Banteay Mean Choăy");
            Add(Country.KH, "2", "Baat Dambang");
            Add(Country.KH, "3", "Kampong Chaam");
            Add(Country.KH, "4", "Kampong Chhnang");
            Add(Country.KH, "5", "Kampong Spueu");
            Add(Country.KH, "6", "Kampong Thum");
            Add(Country.KH, "7", "Kampot");
            Add(Country.KH, "8", "Kandaal");
            Add(Country.KH, "9", "Kaoh Kong");
            Add(Country.KH, "10", "Kracheh");
            Add(Country.KH, "11", "Mondol Kiri");
            Add(Country.KH, "12", "Phnom Penh");
            Add(Country.KH, "13", "Preah Vihear");
            Add(Country.KH, "14", "Prey Veaeng");
            Add(Country.KH, "15", "Pousaat");
            Add(Country.KH, "16", "Rotanak Kiri");
            Add(Country.KH, "17", "Siem Reab");
            Add(Country.KH, "18", "Preah Sihanouk");
            Add(Country.KH, "19", "Stueng Traeng");
            Add(Country.KH, "20", "Svaay Rieng");
            Add(Country.KH, "21", "Taakaev");
            Add(Country.KH, "22", "Otdar Mean Chey");
            Add(Country.KH, "23", "Kaeb");
            Add(Country.KH, "24", "Pailin");
            Add(Country.KH, "25", "Tbong Khmum");

            Debug.Assert(_subdivisionsPerCountry[Country.KH].Count == 25, "Number of subdivisions is wrong.");
        }
    }
}
