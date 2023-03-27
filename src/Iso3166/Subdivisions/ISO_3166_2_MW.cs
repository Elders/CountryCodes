using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:MW is the entry for Malawi in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization (ISO),
        /// which defines codes for the names of the principal subdivisions (e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Malawi, ISO 3166-2 codes are defined for two levels of subdivisions:
        ///     3 regions
        ///     28 districts
        /// Each code consists of two parts, separated by a hyphen.The first part is MW, the ISO 3166-1 alpha-2 code of Malawi.The second part is either of the following:
        ///     one letter: regions
        ///     two letters: districts
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:MW
        /// LastUpdated: 2023-03-22
        /// </remarks>
        internal static void ISO_3166_2_MW()
        {
            Add(Country.MW, "C", "Central Region");
            Add(Country.MW, "N", "Northern Region");
            Add(Country.MW, "S", "Southern Region");
            Add(Country.MW, "BA", "Balaka");
            Add(Country.MW, "BL", "Blantyre");
            Add(Country.MW, "CK", "Chikwawa");
            Add(Country.MW, "CR", "Chiradzul");
            Add(Country.MW, "CT", "Chitipa");
            Add(Country.MW, "DE", "Dedza");
            Add(Country.MW, "DO", "Dowa");
            Add(Country.MW, "KR", "Karonga");
            Add(Country.MW, "KS", "Kasungu");
            Add(Country.MW, "LK", "Likoma");
            Add(Country.MW, "LI", "Lilongwe");
            Add(Country.MW, "MH", "Machinga");
            Add(Country.MW, "MG", "Mangochi");
            Add(Country.MW, "MC", "Mchinji");
            Add(Country.MW, "MU", "Mulanje");
            Add(Country.MW, "MW", "Mwanza");
            Add(Country.MW, "MZ", "Mzimba");
            Add(Country.MW, "NE", "Neno");
            Add(Country.MW, "NB", "Nkhata Bay");
            Add(Country.MW, "NK", "Nkhotakot");
            Add(Country.MW, "NS", "Nsanje");
            Add(Country.MW, "NU", "Ntcheu");
            Add(Country.MW, "NI", "Ntchisi");
            Add(Country.MW, "PH", "Phalombe");
            Add(Country.MW, "RU", "Rumphi");
            Add(Country.MW, "SA", "Salima");
            Add(Country.MW, "TH", "Thyolo");
            Add(Country.MW, "ZO", "Zomba");


            Debug.Assert(_subdivisionsPerCountry[Country.MW].Count == 31, "Number of subdivisions is wrong.");
        }
    }
}
