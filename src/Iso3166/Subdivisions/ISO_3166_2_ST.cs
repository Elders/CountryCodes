using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:ST is the entry for São Tomé and Príncipe(written without diacritics in the standard) in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO),
        /// which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for São Tomé and Príncipe, ISO 3166-2 codes are defined for 1 autonomous region and 6 districts.Each code consists of two parts, separated by a hyphen.The first part is ST,
        /// the ISO 3166-1 alpha-2 code of São Tomé and Príncipe.The second part is a letter for an autonomous region or two digits for a district.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:ST
        /// LastUpdated: 2023-03-21
        /// </remarks>
        internal static void ISO_3166_2_ST()
        {
            Add(Country.ST, "01", "Água Grande");
            Add(Country.ST, "02", "Cantagalo");
            Add(Country.ST, "03", "Caué");
            Add(Country.ST, "04", "Lembá");
            Add(Country.ST, "05", "Lobata");
            Add(Country.ST, "06", "Mé-Zóchi");
            Add(Country.ST, "P", "Príncipe");

            Debug.Assert(_subdivisionsPerCountry[Country.ST].Count == 7, "Number of subdivisions is wrong.");
        }
    }
}
