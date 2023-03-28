using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:JP is the entry for Japan in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO),
        /// which defines codes for the names of the principal subdivisions(e.g.provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Japan, ISO 3166-2 codes are defined for 47 prefectures.
        /// Each code consists of two parts, separated by a hyphen.The first part is JP, the ISO 3166-1 alpha-2 code of Japan.
        /// The second part is two digits(01–47), which is the Japanese Industrial Standard JIS X 0401 code of the prefecture.The codes are assigned roughly from north to south.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:JP
        /// LastUpdated: 2023-03-16
        /// </remarks>
        internal static void ISO_3166_2_JP()
        {
            Add(Country.JP, "23", "Aichi");
            Add(Country.JP, "05", "Akita");
            Add(Country.JP, "02", "Aomori");
            Add(Country.JP, "38", "Ehime");
            Add(Country.JP, "21", "Gifu");
            Add(Country.JP, "10", "Gunma");
            Add(Country.JP, "34", "Hiroshima");
            Add(Country.JP, "01", "Hokkaido");
            Add(Country.JP, "18", "Fukui");
            Add(Country.JP, "40", "Fukuoka");
            Add(Country.JP, "07", "Fukushima");
            Add(Country.JP, "28", "Hyogo");
            Add(Country.JP, "08", "Ibaraki");
            Add(Country.JP, "17", "Ishikawa");
            Add(Country.JP, "03", "Iwate");
            Add(Country.JP, "37", "Kagawa");
            Add(Country.JP, "46", "Kagoshima");
            Add(Country.JP, "14", "Kanagawa");
            Add(Country.JP, "39", "Kochi");
            Add(Country.JP, "43", "Kumamoto");
            Add(Country.JP, "26", "Kyoto");
            Add(Country.JP, "24", "Mie");
            Add(Country.JP, "04", "Miyagi");
            Add(Country.JP, "45", "Miyazaki");
            Add(Country.JP, "20", "Nagano");
            Add(Country.JP, "42", "Nagasaki");
            Add(Country.JP, "29", "Nara");
            Add(Country.JP, "15", "Niigata");
            Add(Country.JP, "44", "Oita");
            Add(Country.JP, "33", "Okayama");
            Add(Country.JP, "47", "Okinawa");
            Add(Country.JP, "27", "Osaka");
            Add(Country.JP, "41", "Saga");
            Add(Country.JP, "11", "Saitama");
            Add(Country.JP, "25", "Shiga");
            Add(Country.JP, "32", "Shimane");
            Add(Country.JP, "22", "Shizuoka");
            Add(Country.JP, "12", "Chiba");
            Add(Country.JP, "36", "Tokushima");
            Add(Country.JP, "13", "Tokyo");
            Add(Country.JP, "09", "Tochigi");
            Add(Country.JP, "31", "Tottori");
            Add(Country.JP, "16", "Toyama");
            Add(Country.JP, "30", "Wakayama");
            Add(Country.JP, "06", "Yamagata");
            Add(Country.JP, "35", "Yamaguchi");
            Add(Country.JP, "19", "Yamanashi");

            Debug.Assert(_subdivisionsPerCountry[Country.JP].Count == 47, $"{Country.JP} Number of subdivisions is wrong.");
        }
    }
}
