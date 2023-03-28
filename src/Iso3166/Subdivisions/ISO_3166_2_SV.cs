using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:SV is the entry for El Salvador in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO),
        /// which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for El Salvador, ISO 3166-2 codes are defined for 14 departments
        /// Each code consists of two parts, separated by a hyphen.The first part is SV, the ISO 3166-1 alpha-2 code of El Salvador.The second part is two letters.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:SV
        /// LastUpdated: 2023-03-22
        /// </remarks>
        internal static void ISO_3166_2_SV()
        {
            Add(Country.SV, "AH", "Ahuachapán");
            Add(Country.SV, "CA", "Cabañas");
            Add(Country.SV, "CH", "Chalatenango");
            Add(Country.SV, "CU", "Cuscatlán");
            Add(Country.SV, "LI", "La Libertad");
            Add(Country.SV, "PA", "La Paz");
            Add(Country.SV, "UN", "La Unión");
            Add(Country.SV, "MO", "Morazán");
            Add(Country.SV, "SM", "San Miguel");
            Add(Country.SV, "SS", "San Salvador");
            Add(Country.SV, "SV", "San Vicente");
            Add(Country.SV, "SA", "Santa Ana");
            Add(Country.SV, "SO", "Sonsonate");
            Add(Country.SV, "US", "Usulután");

            Debug.Assert(_subdivisionsPerCountry[Country.SV].Count == 14, $"{Country.SV} Number of subdivisions is wrong.");
        }
    }
}
