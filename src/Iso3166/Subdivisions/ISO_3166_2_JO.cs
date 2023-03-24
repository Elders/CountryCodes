using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:JO is the entry for Jordan in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO),
        /// which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Jordan, ISO 3166-2 codes are defined for 12 governorates.
        /// Each code consists of two parts, separated by a hyphen.The first part is JO, the ISO 3166-1 alpha-2 code of Jordan.The second part is two letters.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:JO
        /// LastUpdated: 2023-03-24
        /// </remarks>
        internal static void ISO_3166_2_JO()
        {
            Add(Country.JO, "AJ", "‘Ajlūn");
            Add(Country.JO, "AQ", "Al ‘Aqabah");
            Add(Country.JO, "AM", "Al ‘A̅şimah");
            Add(Country.JO, "BA", "Al Balqā’");
            Add(Country.JO, "KA", "Al Karak");
            Add(Country.JO, "MA", "Al Mafraq");
            Add(Country.JO, "AT", "Aţ Ţafīlah");
            Add(Country.JO, "AZ", "Az Zarqā’");
            Add(Country.JO, "IR", "Irbid");
            Add(Country.JO, "JA", "Jarash");
            Add(Country.JO, "MN", "Ma‘ān");
            Add(Country.JO, "MD", "Mādabā");

            Debug.Assert(_subdivisionsPerCountry[Country.JO].Count == 12, "Number of subdivisions is wrong.");
        }
    }
}
