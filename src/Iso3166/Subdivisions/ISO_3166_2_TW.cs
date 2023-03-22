using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:TW is the entry for Taiwan,[1] "Taiwan, Province of China",[2] or "Taiwan (Province of China)",[3] in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization (ISO),
        /// which defines codes for the names of the principal subdivisions (e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// ISO 3166-2:TW defines codes for the subdivisions of Taiwan located on the islands of Taiwan(Formosa), Penghu(Pescadores), Kinmen, Matsu(Lienchiang), and their subsidiary islands.
        /// These areas are de facto under the administration of the government of the Republic of China which resides in Taipei.The government of the People's Republic of China, which resides in Beijing,
        /// also claims these islands but considers ROC-held Fujian islands of Kinmen and Matsu to be within its Fujian Province,[4] not its nominal Taiwan Province (ISO 3166-2 code: CN-TW).
        /// Currently ISO 3166-2:TW lists 13 counties, 3 cities, and 6 special municipalities. Constitutionally the counties and cities are part of the ROC provinces of Taiwan and Fujian,
        /// but since the provincial governments were largely streamlined in 1998 these 22 subdivisions are regarded as the principal subdivisions of Republic of China (Taiwan).
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:TW
        /// LastUpdated: 2023-03-20
        /// </remarks>
        internal static void ISO_3166_2_TW()
        {
            Add(Country.TW, "CHA", "Changhua");
            Add(Country.TW, "CYI", "Chiayi");
            Add(Country.TW, "CYQ", "Chiayi");
            Add(Country.TW, "HSZ", "Hsinchu");
            Add(Country.TW, "HSQ", "Hsinchu");
            Add(Country.TW, "HUA", "Hualien");
            Add(Country.TW, "KHH", "Kaohsiung");
            Add(Country.TW, "KEE", "Keelung");
            Add(Country.TW, "KIN", "Kinmen");
            Add(Country.TW, "LIE", "Lienchiang");
            Add(Country.TW, "MIA", "Miaoli");
            Add(Country.TW, "NAN", "Nantou");
            Add(Country.TW, "NWT", "New Taipei");
            Add(Country.TW, "PEN", "Penghu");
            Add(Country.TW, "PIF", "Pingtung");
            Add(Country.TW, "TXG", "Taichung");
            Add(Country.TW, "TNN", "Tainan");
            Add(Country.TW, "TPE", "Taipei");
            Add(Country.TW, "TTT", "Taitung");
            Add(Country.TW, "TAO", "Taoyuan");
            Add(Country.TW, "ILA", "Yilan");
            Add(Country.TW, "YUN", "Yunlin");

            Debug.Assert(_subdivisionsPerCountry[Country.TW].Count == 22, "Number of subdivisions is wrong.");
        }
    }
}
