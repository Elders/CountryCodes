using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:BW is the entry for Botswana in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization (ISO),
        /// which defines codes for the names of the principal subdivisions (e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Botswana, ISO 3166-2 codes are defined for 10 districts, 4 towns, and 2 cities.
        /// Each code consists of two parts, separated by a hyphen.The first part is BW, the ISO 3166-1 alpha-2 code of Botswana.The second part is two letters.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:BW
        /// LastUpdated: 2023-03-22
        /// </remarks>
        internal static void ISO_3166_2_BW()
        {
            Add(Country.BW, "CE", "Central");
            Add(Country.BW, "CH", "Chobe");
            Add(Country.BW, "FR", "Francistown");
            Add(Country.BW, "GA", "Gaborone");
            Add(Country.BW, "GH", "Ghanzi");
            Add(Country.BW, "JW", "Jwaneng");
            Add(Country.BW, "KG", "Kgalagadi");
            Add(Country.BW, "KL", "Kgatleng");
            Add(Country.BW, "KW", "Kweneng");
            Add(Country.BW, "LO", "Lobatse");
            Add(Country.BW, "NE", "North East");
            Add(Country.BW, "NW", "North West");
            Add(Country.BW, "SP", "Selibe Phikwe");
            Add(Country.BW, "SE", "South East");
            Add(Country.BW, "SO", "Southern");
            Add(Country.BW, "ST", "Sowa Town");

            Debug.Assert(_subdivisionsPerCountry[Country.BW].Count == 16, $"{Country.BW} Number of subdivisions is wrong.");
        }
    }
}
