using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:BE is the entry for Belgium in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization (ISO),
        /// which defines codes for the names of the principal subdivisions (e.g. provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Belgium, ISO 3166-2 codes are defined for two levels of subdivisions:
        ///  3 regions
        ///  10 provinces
        /// Each code consists of two parts, separated by a hyphen.The first part is BE, the ISO 3166-1 alpha-2 code of Belgium.The second part is three letters.
        /// For the provinces, the first letter indicates the region where the province is in:
        ///  V: Flemish Region (Dutch: Vlaams Gewest)
        ///  W: Walloon Region(French: Région wallonne)
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:BE
        /// LastUpdated: 2023-03-16
        /// </remarks>
        internal static void ISO_3166_2_BE()
        {
            Add(Country.BE, "BRU", "Brussels-Capital Region");
            Add(Country.BE, "VLG", "Flemish Region");
            Add(Country.BE, "WAL", "Walloon Region");
            Add(Country.BE, "VAN", "Antwerpen");
            Add(Country.BE, "WBR", "Brabant wallon");
            Add(Country.BE, "WHT", "Hainaut");
            Add(Country.BE, "WLG", "Liège");
            Add(Country.BE, "VLI", "Limburg");
            Add(Country.BE, "WLX", "Luxembourg");
            Add(Country.BE, "WNA", "Namur");
            Add(Country.BE, "VOV", "Oost-Vlaanderen");
            Add(Country.BE, "VBR", "Vlaams-Brabant");
            Add(Country.BE, "VWV", "West-Vlaanderen");

            Debug.Assert(_subdivisionsPerCountry[Country.BE].Count == 13, "Number of subdivisions is wrong.");
        }
    }
}
