using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:GL is the entry for Greenland in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization (ISO),
        /// which defines codes for the names of the principal subdivisions (e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Greenland, ISO 3166-2 codes are defined for 5 municipalities.The Northeast Greenland National Park and the Thule Air Base,
        /// which are unincorporated and not part of any municipality, are not listed.
        /// Each code consists of two parts, separated by a hyphen. The first part is GL,
        /// the ISO 3166-1 alpha-2 code of Greenland.The second part is two letters.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:GL
        /// LastUpdated: 2023-03-23
        /// </remarks>
        internal static void ISO_3166_2_GL()
        {
            Add(Country.GL, "AV", "Avannaata Kommunia");
            Add(Country.GL, "KU", "Kommune Kujalleq");
            Add(Country.GL, "QT", "Kommune Qeqertalik");
            Add(Country.GL, "SM", "Kommuneqarfik Sermersooq");
            Add(Country.GL, "QE", "Qeqqata Kommunia");

            Debug.Assert(_subdivisionsPerCountry[Country.GL].Count == 5, $"{Country.GL} Number of subdivisions is wrong.");
        }
    }
}
