using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:KE is the entry for Kenya in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO),
        /// which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Kenya, ISO 3166-2 codes are defined for 47 counties.
        /// Each code consists of two parts, separated by a hyphen.The first part is KE, the ISO 3166-1 alpha-2 code of Kenya.The second part is two digits.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:KE
        /// LastUpdated: 2023-03-24
        /// </remarks>
        internal static void ISO_3166_2_KE()
        {
            Add(Country.KE, "01", "Baringo");
            Add(Country.KE, "02", "Bomet");
            Add(Country.KE, "03", "Bungoma");
            Add(Country.KE, "04", "Busia");
            Add(Country.KE, "05", "Elgeyo/Marakwet");
            Add(Country.KE, "06", "Embu");
            Add(Country.KE, "07", "Garissa");
            Add(Country.KE, "08", "Homa Bay");
            Add(Country.KE, "09", "Isiolo");
            Add(Country.KE, "10", "Kajiado");
            Add(Country.KE, "11", "Kakamega");
            Add(Country.KE, "12", "Kericho");
            Add(Country.KE, "13", "Kiambu");
            Add(Country.KE, "14", "Kilifi");
            Add(Country.KE, "15", "Kirinyaga");
            Add(Country.KE, "16", "Kisii");
            Add(Country.KE, "17", "Kisumu");
            Add(Country.KE, "18", "Kitui");
            Add(Country.KE, "19", "Kwale");
            Add(Country.KE, "20", "Laikipia");
            Add(Country.KE, "21", "Lamu");
            Add(Country.KE, "22", "Machakos");
            Add(Country.KE, "23", "Makueni");
            Add(Country.KE, "24", "Mandera");
            Add(Country.KE, "25", "Marsabit");
            Add(Country.KE, "26", "Meru");
            Add(Country.KE, "27", "Migori");
            Add(Country.KE, "28", "Mombasa");
            Add(Country.KE, "29", "Murang'a");
            Add(Country.KE, "30", "Nairobi City");
            Add(Country.KE, "31", "Nakuru");
            Add(Country.KE, "32", "Nandi");
            Add(Country.KE, "33", "Narok");
            Add(Country.KE, "34", "Nyamira");
            Add(Country.KE, "35", "Nyandarua");
            Add(Country.KE, "36", "Nyeri");
            Add(Country.KE, "37", "Samburu");
            Add(Country.KE, "38", "Siaya");
            Add(Country.KE, "39", "Taita/Taveta");
            Add(Country.KE, "40", "Tana River");
            Add(Country.KE, "41", "Tharaka-Nithi");
            Add(Country.KE, "42", "Trans Nzoia");
            Add(Country.KE, "43", "Turkana");
            Add(Country.KE, "44", "Uasin Gishu");
            Add(Country.KE, "45", "Vihiga");
            Add(Country.KE, "46", "Wajir");
            Add(Country.KE, "47", "West Pokot");

            Debug.Assert(_subdivisionsPerCountry[Country.KE].Count == 47, $"{Country.KE} Number of subdivisions is wrong.");
        }
    }
}
