using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:SD is the entry for Sudan in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO),
        /// which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Sudan, ISO 3166-2 codes are defined for 18 states.
        /// Each code consists of two parts, separated by a hyphen.The first part is SD, the ISO 3166-1 alpha-2 code of Sudan.The second part is two letters.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:SD
        /// LastUpdated: 2023-03-20
        /// </remarks>
        internal static void ISO_3166_2_SD()
        {
            Add(Country.SD, "RS", "Red Sea");
            Add(Country.SD, "GZ", "Gezira");
            Add(Country.SD, "KH", "Khartoum");
            Add(Country.SD, "GD", "Gedaref");
            Add(Country.SD, "NW", "White Nile");
            Add(Country.SD, "NB", "Blue Nile");
            Add(Country.SD, "NO", "Northern");
            Add(Country.SD, "DW", "West Darfur");
            Add(Country.SD, "GK", "West Kordofan");
            Add(Country.SD, "DS", "South Darfur");
            Add(Country.SD, "KS", "South Kordofan");
            Add(Country.SD, "KA", "Kassala");
            Add(Country.SD, "NR", "River Nile");
            Add(Country.SD, "DN", "North Darfur");
            Add(Country.SD, "KN", "North Kordofan");
            Add(Country.SD, "DE", "East Darfur");
            Add(Country.SD, "SI", "Sennar");
            Add(Country.SD, "DC", "Central Darfur");

            Debug.Assert(_subdivisionsPerCountry[Country.SD].Count == 18, "Number of subdivisions is wrong.");
        }
    }
}
