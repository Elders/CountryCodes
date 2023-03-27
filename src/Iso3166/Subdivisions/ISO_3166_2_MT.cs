using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:MT is the entry for Malta in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO),
        /// which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Malta, ISO 3166-2 codes are defined for 68 local councils.
        /// Each code consists of two parts, separated by a hyphen. The first part is MT, the ISO 3166-1 alpha-2 code of Malta.The second part is two digits (01–68).
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:MT
        /// LastUpdated: 2023-03-22
        /// </remarks>
        internal static void ISO_3166_2_MT()
        {
            Add(Country.MT, "01", "Attard");
            Add(Country.MT, "02", "Balzan");
            Add(Country.MT, "03", "Birgu");
            Add(Country.MT, "04", "Birkirkara");
            Add(Country.MT, "05", "Birżebbuġa");
            Add(Country.MT, "06", "Bormla");
            Add(Country.MT, "07", "Dingli");
            Add(Country.MT, "08", "Fgura");
            Add(Country.MT, "09", "Floriana");
            Add(Country.MT, "10", "Fontana");
            Add(Country.MT, "11", "Gudja");
            Add(Country.MT, "12", "Gżira");
            Add(Country.MT, "13", "Għajnsielem");
            Add(Country.MT, "14", "Għarb");
            Add(Country.MT, "15", "Għargħur");
            Add(Country.MT, "16", "Għasri");
            Add(Country.MT, "17", "Għaxaq");
            Add(Country.MT, "18", "Ħamrun");
            Add(Country.MT, "19", "Iklin");
            Add(Country.MT, "20", "Isla	");
            Add(Country.MT, "21", "Kalkara");
            Add(Country.MT, "22", "Kerċem");
            Add(Country.MT, "23", "Kirkop");
            Add(Country.MT, "24", "Lija");
            Add(Country.MT, "25", "Luqa");
            Add(Country.MT, "26", "Marsa");
            Add(Country.MT, "27", "Marsaskala");
            Add(Country.MT, "28", "Marsaxlokk");
            Add(Country.MT, "29", "Mdina");
            Add(Country.MT, "30", "Mellieħa");
            Add(Country.MT, "31", "Mġarr");
            Add(Country.MT, "32", "Mosta");
            Add(Country.MT, "33", "Mqabbaa");
            Add(Country.MT, "34", "Msida");
            Add(Country.MT, "35", "Mtarfaa");
            Add(Country.MT, "36", "Munxar");
            Add(Country.MT, "37", "Nadur");
            Add(Country.MT, "38", "Naxxar");
            Add(Country.MT, "39", "Paola");
            Add(Country.MT, "40", "Pembroke");
            Add(Country.MT, "41", "Pietà");
            Add(Country.MT, "42", "Qala");
            Add(Country.MT, "43", "Qormi");
            Add(Country.MT, "44", "Qrendi");
            Add(Country.MT, "45", "Rabat Gozo");
            Add(Country.MT, "46", "Rabat Malta");
            Add(Country.MT, "47", "Safi");
            Add(Country.MT, "48", "Saint Julian's");
            Add(Country.MT, "49", "Saint John");
            Add(Country.MT, "50", "Saint Lawrence");
            Add(Country.MT, "51", "Saint Paul's Bay");
            Add(Country.MT, "52", "Sannat");
            Add(Country.MT, "53", "Saint Lucia's");
            Add(Country.MT, "54", "Santa Venera	");
            Add(Country.MT, "55", "Siġġiewi");
            Add(Country.MT, "56", "Sliema");
            Add(Country.MT, "57", "Swieqi");
            Add(Country.MT, "58", "Ta' Xbiex");
            Add(Country.MT, "59", "Tarxien");
            Add(Country.MT, "60", "Valletta");
            Add(Country.MT, "61", "Xagħra");
            Add(Country.MT, "62", "Xewkija");
            Add(Country.MT, "63", "Xgħajra");
            Add(Country.MT, "64", "Żabbar");
            Add(Country.MT, "65", "Żebbuġ");
            Add(Country.MT, "66", "Żebbuġ");
            Add(Country.MT, "67", "Żejtun");
            Add(Country.MT, "68", "Żurrieq");

            Debug.Assert(_subdivisionsPerCountry[Country.MT].Count == 68, "Number of subdivisions is wrong.");
        }
    }
}
