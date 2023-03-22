using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:LC is the entry for Saint Lucia in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO),
        /// which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Saint Lucia, ISO 3166-2 codes are defined for 10 districts.
        /// Each code consists of two parts, separated by a hyphen.The first part is LC, the ISO 3166-1 alpha-2 code of Saint Lucia.The second part is two digits (01–12) except 04 and 09.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:LC
        /// LastUpdated: 2023-03-21
        /// </remarks>
        internal static void ISO_3166_2_LC()
        {
            Add(Country.LC, "01", "Anse la Raye");
            Add(Country.LC, "12", "Canaries");
            Add(Country.LC, "02", "Castries");
            Add(Country.LC, "03", "Choiseul");
            Add(Country.LC, "05", "Dennery");
            Add(Country.LC, "06", "Gros Islet");
            Add(Country.LC, "07", "Laborie");
            Add(Country.LC, "08", "Micoud");
            Add(Country.LC, "10", "Soufrière");
            Add(Country.LC, "11", "Vieux Fort");

            Debug.Assert(_subdivisionsPerCountry[Country.LC].Count == 11, "Number of subdivisions is wrong.");
        }
    }
}
