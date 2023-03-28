using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:GH is the entry for Ghana in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization (ISO),
        /// which defines codes for the names of the principal subdivisions (e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Ghana, ISO 3166-2 codes are defined for 16 regions.
        /// Each code consists of two parts, separated by a hyphen.The first part is GH, the ISO 3166-1 alpha-2 code of Ghana.The second part is two letters.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:GH
        /// LastUpdated: 2023-03-23
        /// </remarks>
        internal static void ISO_3166_2_GH()
        {
            Add(Country.GH, "BA", "Brong-Ahafo");
            Add(Country.GH, "AF", "Ahafo");
            Add(Country.GH, "AH", "Ashanti");
            Add(Country.GH, "BO", "Bono");
            Add(Country.GH, "BE", "Bono East");
            Add(Country.GH, "CP", "Central");
            Add(Country.GH, "EP", "Eastern");
            Add(Country.GH, "AA", "Greater Accra");
            Add(Country.GH, "NE", "North East");
            Add(Country.GH, "NP", "Northern");
            Add(Country.GH, "OT", "Oti");
            Add(Country.GH, "SV", "Savannah");
            Add(Country.GH, "UE", "Upper East");
            Add(Country.GH, "UW", "Upper West");
            Add(Country.GH, "TV", "Volta");
            Add(Country.GH, "WP", "Western");
            Add(Country.GH, "WN", "Western North");

            Debug.Assert(_subdivisionsPerCountry[Country.GH].Count == 17, $"{Country.GH} Number of subdivisions is wrong.");
        }
    }
}
