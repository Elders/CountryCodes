using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:MA is the entry for Morocco in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization (ISO),
        /// which defines codes for the names of the principal subdivisions (e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Morocco, ISO 3166-2 codes are defined for two levels of subdivisions:
        ///         12 regions
        ///         62 provinces and 13 prefectures
        /// Each code consists of two parts, separated by a hyphen.The first part is MA, the ISO 3166-1 alpha-2 code of Morocco.The second part is either of the following:
        ///         two digits (01–12): regions
        ///         three letters: provinces and prefectures
        /// The codes for the regions are assigned roughly from north to south.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:MA
        /// LastUpdated: 2023-03-22
        /// </remarks>
        internal static void ISO_3166_2_MA()
        {
            Add(Country.MA, "05", "Béni Mellal-Khénifra");
            Add(Country.MA, "06", "Casablanca-Settat");
            Add(Country.MA, "12", "Dakhla-Oued Ed-Dahab");
            Add(Country.MA, "08", "Drâa-Tafilalet");
            Add(Country.MA, "03", "Fès-Meknès");
            Add(Country.MA, "10", "Guelmim-Oued Noun");
            Add(Country.MA, "02", "L'Oriental");
            Add(Country.MA, "11", "Laâyoune-Sakia El Hamra");
            Add(Country.MA, "07", "Marrakech-Safi");
            Add(Country.MA, "04", "Rabat-Salé-Kénitra");
            Add(Country.MA, "09", "Souss-Massa");
            Add(Country.MA, "01", "Tanger-Tétouan-Al Hoceïma");

            Debug.Assert(_subdivisionsPerCountry[Country.MA].Count == 12, $"{Country.MA} Number of subdivisions is wrong.");
        }
    }
}
