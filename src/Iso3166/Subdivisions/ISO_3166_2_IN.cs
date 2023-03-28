using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:IN is the entry for India in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO),
        /// which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for India, ISO 3166-2 codes are defined for 28 states and 8 union territories.
        /// Each code consists of two parts, separated by a hyphen. The first part is IN, the ISO 3166-1 alpha-2 code for India.The second part is two letters,
        /// currently used in vehicle registration plates with some exceptions.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:IN
        /// LastUpdated: 2023-03-23
        /// </remarks>
        internal static void ISO_3166_2_IN()
        {
            Add(Country.IN, "AP", "Andhra Pradesh");
            Add(Country.IN, "AR", "Arunāchal Pradesh");
            Add(Country.IN, "AS", "Assam");
            Add(Country.IN, "BR", "Bihār");
            Add(Country.IN, "CT", "Chhattīsgarh");
            Add(Country.IN, "GA", "Goa");
            Add(Country.IN, "GJ", "Gujarāt");
            Add(Country.IN, "HR", "Haryāna");
            Add(Country.IN, "HP", "Himāchal Pradesh");
            Add(Country.IN, "JH", "Jhārkhand");
            Add(Country.IN, "KA", "Karnātaka");
            Add(Country.IN, "KL", "Kerala");
            Add(Country.IN, "MP", "Madhya Pradesh");
            Add(Country.IN, "MH", "Mahārāshtra");
            Add(Country.IN, "MN", "Manipur");
            Add(Country.IN, "ML", "Meghālaya");
            Add(Country.IN, "MZ", "Mizoram");
            Add(Country.IN, "NL", "Nāgāland");
            Add(Country.IN, "OR", "Odisha");
            Add(Country.IN, "PB", "Punjab");
            Add(Country.IN, "RJ", "Rājasthān");
            Add(Country.IN, "SK", "Sikkim");
            Add(Country.IN, "TN", "Tamil Nādu");
            Add(Country.IN, "TG", "Telangāna");
            Add(Country.IN, "TR", "Tripura");
            Add(Country.IN, "UT", "Uttarākhand");
            Add(Country.IN, "UP", "Uttar Pradesh");
            Add(Country.IN, "WB", "West Bengal");
            Add(Country.IN, "AN", "Andaman and Nicobar Islands");
            Add(Country.IN, "CH", "Chandīgarh");
            Add(Country.IN, "DH", "Dādra and Nagar Haveli and Damān and Diu");
            Add(Country.IN, "DL", "Delhi");
            Add(Country.IN, "JK", "Jammu and Kashmīr");
            Add(Country.IN, "LA", "Ladākh");
            Add(Country.IN, "LD", "Lakshadweep");
            Add(Country.IN, "PY", "Puducherry");

            Debug.Assert(_subdivisionsPerCountry[Country.IN].Count == 36, $"{Country.IN} Number of subdivisions is wrong.");
        }
    }
}
