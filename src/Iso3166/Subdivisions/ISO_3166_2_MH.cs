using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:MH is the entry for the Marshall Islands in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization (ISO),
        /// which defines codes for the names of the principal subdivisions (e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for the Marshall Islands, ISO 3166-2 codes are defined for two levels of subdivisions:
        ///     2 chains(of islands) (i.e., the Ralik Chain and the Ratak Chain)
        ///     24 municipalities
        /// The municipalities are inhabited atolls or islands.The ten uninhabited atolls and islands of the country are not listed:
        ///     In Ralik Chain: Ailinginae Atoll, Bikini Atoll, Rongerik Atoll, and Ujelang Atoll (previously inhabited and had its code deleted in Newsletter II-1)
        ///     In Ratak Chain: Bikar Atoll, Bokak Atoll, Erikub Atoll, Jemo Island, Nadikdik Atoll, and Toke Atoll
        /// Each code consists of two parts, separated by a hyphen.The first part is MH, the ISO 3166-1 alpha-2 code of the Marshall Islands.The second part is either of the following:
        ///     one letter: chains(of islands)
        ///     three letters: municipalities
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:MH
        /// LastUpdated: 2023-03-22
        /// </remarks>
        internal static void ISO_3166_2_MH()
        {
            Add(Country.MH, "L", "Ralik chain");
            Add(Country.MH, "T", "Ratak chain");
            Add(Country.MH, "ALL", "Ailinglaplap");
            Add(Country.MH, "ALK", "Ailuk");
            Add(Country.MH, "ARN", "Arno");
            Add(Country.MH, "AUR", "Aur");
            Add(Country.MH, "KIL", "Bikini & Kili");
            Add(Country.MH, "EBO", "Ebon");
            Add(Country.MH, "ENI", "Enewetak & Ujelanḡ");
            Add(Country.MH, "JAB", "Jabat");
            Add(Country.MH, "JAL", "Jaluit");
            Add(Country.MH, "KWA", "Kwajalein");
            Add(Country.MH, "LAE", "Lae	Lae");
            Add(Country.MH, "LIB", "Lib	Ellep");
            Add(Country.MH, "LIK", "Likiep");
            Add(Country.MH, "MAJ", "Majuro");
            Add(Country.MH, "MAL", "Maloelap");
            Add(Country.MH, "MEJ", "Mejit");
            Add(Country.MH, "MIL", "Mili");
            Add(Country.MH, "NMK", "Namdrik");
            Add(Country.MH, "NMU", "Namu");
            Add(Country.MH, "RON", "Rongelap");
            Add(Country.MH, "UJA", "Ujae");
            Add(Country.MH, "UTI", "Utrik");
            Add(Country.MH, "WTH", "Wotho");
            Add(Country.MH, "WTJ", "Wotje");

            Debug.Assert(_subdivisionsPerCountry[Country.MH].Count == 26, "Number of subdivisions is wrong.");
        }
    }
}
