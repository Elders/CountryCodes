using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:CN is the entry for China in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization (ISO), which defines codes for the names of the principal subdivisions (e.g. provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for China, ISO 3166-2 codes are defined for the following province-level subdivisions:
        /// 23 provinces
        /// 4 direct-administered municipalities
        /// 5 autonomous regions
        /// 2 special administrative regions
        /// The full name of China in ISO 3166 is the People's Republic of China[1] (PRC). Yet China is de facto divided into the PRC and the Republic of China (Taiwan) with limited recognition. Taiwan, which consists of the namesake island and the Penghu Islands, is included as a province of China because[2] of its political status within the United Nations, as even though it is de facto under the jurisdiction of the Republic of China instead of the People's Republic of China("China"), the United Nations considers Taiwan as part of "China". In addition, Kinmen and the Matsu Islands in the fractured Fuchien(Fujian) Province are also governed by the ROC.
        /// Each code consists of two parts, separated by a hyphen.The first part is CN, the ISO 3166-1 alpha-2 code of China.The second part is a two-letter alphabetic code specified by Guobiao GB/T 2260 (first published 1991, prior to ISO 3166-2, first published 1998).
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:CN
        /// LastUpdated: 2023-03-15
        /// </remarks>
        internal static void ISO_3166_2_CN()
        {
            Add(Country.CN, "AH", "Anhui Sheng");
            Add(Country.CN, "BJ", "Beijing Shi");
            Add(Country.CN, "CQ", "Chongqing Shi");
            Add(Country.CN, "FJ", "Fujian Sheng");
            Add(Country.CN, "GD", "Guangdong Sheng");
            Add(Country.CN, "GS", "Gansu Sheng");
            Add(Country.CN, "GX", "Guangxi Zhuangzu Zizhiqu");
            Add(Country.CN, "GZ", "Guizhou Sheng");
            Add(Country.CN, "HA", "Henan Sheng");
            Add(Country.CN, "HB", "Hubei Sheng");
            Add(Country.CN, "HE", "Hebei Sheng");
            Add(Country.CN, "HI", "Hainan Sheng");
            Add(Country.CN, "HK", "Hong Kong SAR (en)");
            Add(Country.CN, "HL", "Heilongjiang Sheng");
            Add(Country.CN, "HN", "Hunan Sheng");
            Add(Country.CN, "JL", "Jilin Sheng");
            Add(Country.CN, "JS", "Jiangsu Sheng");
            Add(Country.CN, "JX", "Jiangxi Sheng");
            Add(Country.CN, "LN", "Liaoning Sheng");
            Add(Country.CN, "MO", "Macao SAR (en)");
            Add(Country.CN, "NM", "Nei Mongol Zizhiqu");
            Add(Country.CN, "NX", "Ningxia Huizu Zizhiqu");
            Add(Country.CN, "QH", "Qinghai Sheng");
            Add(Country.CN, "SC", "Sichuan Sheng");
            Add(Country.CN, "SD", "Shandong Sheng");
            Add(Country.CN, "SH", "Shanghai Shi");
            Add(Country.CN, "SN", "Shaanxi Sheng");
            Add(Country.CN, "SX", "Shanxi Sheng");
            Add(Country.CN, "TJ", "Tianjin Shi");
            Add(Country.CN, "TW", "Taiwan Sheng");
            Add(Country.CN, "XJ", "Xinjiang Uygur Zizhiqu");
            Add(Country.CN, "XZ", "Xizang Zizhiqu");
            Add(Country.CN, "YN", "Yunnan Sheng");
            Add(Country.CN, "ZJ", "Zhejiang Sheng");

            Debug.Assert(_subdivisionsPerCountry[Country.CN].Count == 34, "Number of subdivisions is wrong.");
        }
    }
}
