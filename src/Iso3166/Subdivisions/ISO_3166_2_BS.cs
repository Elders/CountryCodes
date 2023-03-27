using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:BS is the entry for the Bahamas in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization (ISO),
        /// which defines codes for the names of the principal subdivisions (e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for the Bahamas, ISO 3166-2 codes are defined for 1 island(New Providence) and 31 districts.
        /// Each code consists of two parts, separated by a hyphen.The first part is BS, the ISO 3166-1 alpha-2 code of the Bahamas.The second part is two letters.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:BS
        /// LastUpdated: 2023-03-22
        /// </remarks>
        internal static void ISO_3166_2_BS()
        {
            Add(Country.BS, "AK", "Acklins");
            Add(Country.BS, "BY", "Berry Islands");
            Add(Country.BS, "BI", "Bimini");
            Add(Country.BS, "BP", "Black Point");
            Add(Country.BS, "CI", "Cat Island");
            Add(Country.BS, "CO", "Central Abaco");
            Add(Country.BS, "CS", "Central Andros");
            Add(Country.BS, "CE", "Central Eleuthera");
            Add(Country.BS, "FP", "City of Freeport");
            Add(Country.BS, "CK", "Crooked Island and Long Cay");
            Add(Country.BS, "EG", "East Grand Bahama");
            Add(Country.BS, "EX", "Exuma");
            Add(Country.BS, "GC", "Grand Cay");
            Add(Country.BS, "HI", "Harbour Island");
            Add(Country.BS, "HT", "Hope Town");
            Add(Country.BS, "IN", "Inagua");
            Add(Country.BS, "LI", "Long Island");
            Add(Country.BS, "MC", "Mangrove Cay");
            Add(Country.BS, "MG", "Mayaguana");
            Add(Country.BS, "MI", "Moore's Island");
            Add(Country.BS, "NP", "New Providence island");
            Add(Country.BS, "NO", "North Abaco");
            Add(Country.BS, "NS", "North Andros");
            Add(Country.BS, "NE", "North Eleuthera");
            Add(Country.BS, "RI", "Ragged Island");
            Add(Country.BS, "RC", "Rum Cay");
            Add(Country.BS, "SS", "San Salvador");
            Add(Country.BS, "SO", "South Abaco");
            Add(Country.BS, "SA", "South Andros");
            Add(Country.BS, "SE", "South Eleuthera");
            Add(Country.BS, "SW", "Spanish Wells");
            Add(Country.BS, "WG", "West Grand Bahama");

            Debug.Assert(_subdivisionsPerCountry[Country.BS].Count == 32, "Number of subdivisions is wrong.");
        }
    }
}
