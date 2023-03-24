using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:KZ is the entry for Kazakhstan in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO),
        /// which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Kazakhstan, ISO 3166-2 codes are defined for 3 cities and 17 regions.
        /// The cities Almaty and Astana are the former and current capitals of the country respectively and have special status equal to the regions.
        /// Each code consists of two parts, separated by a hyphen.The first part is KZ, the ISO 3166-1 alpha-2 code of Kazakhstan.The second part is two digits.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:KZ
        /// LastUpdated: 2023-03-24
        /// </remarks>
        internal static void ISO_3166_2_KZ()
        {
            Add(Country.KZ, "10", "Abay oblysy");
            Add(Country.KZ, "11", "Aqmola oblysy");
            Add(Country.KZ, "15", "Aqtöbe oblysy");
            Add(Country.KZ, "19", "Almaty oblysy");
            Add(Country.KZ, "23", "Atyraū oblysy");
            Add(Country.KZ, "27", "Batys Qazaqstan oblysy");
            Add(Country.KZ, "31", "Zhambyl oblysy");
            Add(Country.KZ, "33", "Zhetisū oblysy");
            Add(Country.KZ, "35", "Qaraghandy oblysy");
            Add(Country.KZ, "39", "Qostanay oblysy");
            Add(Country.KZ, "43", "Qyzylorda oblysy");
            Add(Country.KZ, "47", "Mangghystaū oblysy");
            Add(Country.KZ, "55", "Pavlodar oblysy");
            Add(Country.KZ, "59", "Soltüstik Qazaqstan oblysy");
            Add(Country.KZ, "61", "Türkistan oblysy");
            Add(Country.KZ, "62", "Ulytaū oblysy");
            Add(Country.KZ, "63", "Shyghys Qazaqstan oblysy");
            Add(Country.KZ, "71", "Astana");
            Add(Country.KZ, "75", "Almaty");
            Add(Country.KZ, "79", "Shymkent");

            Debug.Assert(_subdivisionsPerCountry[Country.KZ].Count == 20, "Number of subdivisions is wrong.");
        }
    }
}
