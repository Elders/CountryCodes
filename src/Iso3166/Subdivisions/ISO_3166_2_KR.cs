using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:KR is the entry for South Korea(officially the Republic of Korea) in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO),
        /// which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for South Korea, ISO 3166-2 codes are defined for 1 special city, 6 metropolitan cities, 8 provinces, 1 special self-governing province, and 1 special self-governing city.All of them are province-level subdivisions.
        /// Each code consists of two parts, separated by a hyphen. The first part is KR, the ISO 3166-1 alpha-2 code of South Korea. The second part is two digits:
        ///     11: special city
        ///     26–31: metropolitan cities
        ///     41–48: provinces
        ///     49: special self-governing province
        ///     50: special self-governing city
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:KR
        /// LastUpdated: 2023-03-24
        /// </remarks>
        internal static void ISO_3166_2_KR()
        {
            Add(Country.KR, "11", "Seoul");
            Add(Country.KR, "26", "Busan");
            Add(Country.KR, "27", "Daegu");
            Add(Country.KR, "30", "Daejeon");
            Add(Country.KR, "29", "Gwangju");
            Add(Country.KR, "28", "Incheon");
            Add(Country.KR, "31", "Ulsan");
            Add(Country.KR, "43", "North Chungcheong");
            Add(Country.KR, "44", "South Chungcheong");
            Add(Country.KR, "42", "Gangwon");
            Add(Country.KR, "41", "Gyeonggi");
            Add(Country.KR, "47", "North Gyeongsang");
            Add(Country.KR, "48", "South Gyeongsang");
            Add(Country.KR, "45", "North Jeolla");
            Add(Country.KR, "46", "South Jeolla");
            Add(Country.KR, "49", "Jeju");
            Add(Country.KR, "50", "Sejong");

            Debug.Assert(_subdivisionsPerCountry[Country.KR].Count == 17, "Number of subdivisions is wrong.");
        }
    }
}
