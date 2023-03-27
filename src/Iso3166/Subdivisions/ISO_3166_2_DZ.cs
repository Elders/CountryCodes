using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:DZ is the entry for Algeria in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization (ISO),
        /// which defines codes for the names of the principal subdivisions (e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Algeria, ISO 3166-2 codes are defined for 58 provinces.
        /// Each code consists of two parts, separated by a hyphen.The first part is DZ, the ISO 3166-1 alpha-2 code of Algeria.The second part is two digits:
        ///     01–31: provinces created in 1974
        ///     32–48: provinces created in 1983
        ///     49–58: provinces created in 2019
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:DZ
        /// LastUpdated: 2023-03-20
        /// </remarks>
        internal static void ISO_3166_2_DZ()
        {
            Add(Country.DZ, "01", "Adrar");
            Add(Country.DZ, "02", "Chlef");
            Add(Country.DZ, "03", "Laghouat");
            Add(Country.DZ, "04", "Oum el Bouaghi");
            Add(Country.DZ, "05", "Batna");
            Add(Country.DZ, "06", "Béjaïa");
            Add(Country.DZ, "07", "Biskra");
            Add(Country.DZ, "08", "Béchar");
            Add(Country.DZ, "09", "Blida");
            Add(Country.DZ, "10", "Bouira");
            Add(Country.DZ, "11", "Tamanghasset");
            Add(Country.DZ, "12", "Tébessa");
            Add(Country.DZ, "13", "Tlemcen");
            Add(Country.DZ, "14", "Tiaret");
            Add(Country.DZ, "15", "Tizi Ouzou");
            Add(Country.DZ, "16", "Alger");
            Add(Country.DZ, "17", "Djelfa");
            Add(Country.DZ, "18", "Jijel");
            Add(Country.DZ, "19", "Sétif");
            Add(Country.DZ, "20", "Saïda");
            Add(Country.DZ, "21", "Skikda");
            Add(Country.DZ, "22", "Sidi Bel Abbès");
            Add(Country.DZ, "23", "Annaba");
            Add(Country.DZ, "24", "Guelma");
            Add(Country.DZ, "25", "Constantine");
            Add(Country.DZ, "26", "Médéa");
            Add(Country.DZ, "27", "Mostaganem");
            Add(Country.DZ, "28", "Msila");
            Add(Country.DZ, "29", "Mascara");
            Add(Country.DZ, "30", "Ouargla");
            Add(Country.DZ, "31", "Oran");
            Add(Country.DZ, "32", "El Bayadh");
            Add(Country.DZ, "33", "Illizi");
            Add(Country.DZ, "34", "Bordj Bou Arréridj");
            Add(Country.DZ, "35", "Boumerdès");
            Add(Country.DZ, "36", "El Tarf");
            Add(Country.DZ, "37", "Tindouf");
            Add(Country.DZ, "38", "Tissemsilt");
            Add(Country.DZ, "39", "El Oued");
            Add(Country.DZ, "40", "Khenchela");
            Add(Country.DZ, "41", "Souk Ahras");
            Add(Country.DZ, "42", "Tipasa");
            Add(Country.DZ, "43", "Mila");
            Add(Country.DZ, "44", "Aïn Defla");
            Add(Country.DZ, "45", "Naama");
            Add(Country.DZ, "46", "Aïn Témouchent");
            Add(Country.DZ, "47", "Ghardaïa");
            Add(Country.DZ, "48", "Relizane");
            Add(Country.DZ, "49", "Timimoun");
            Add(Country.DZ, "50", "Bordj Badji Mokhtar");
            Add(Country.DZ, "51", "Ouled Djellal");
            Add(Country.DZ, "52", "Béni Abbès");
            Add(Country.DZ, "53", "	In Salah");
            Add(Country.DZ, "54", "In Guezzam");
            Add(Country.DZ, "55", "Touggourt");
            Add(Country.DZ, "56", "Djanet");
            Add(Country.DZ, "57", "El Meghaier");
            Add(Country.DZ, "58", "El Meniaa");

            Debug.Assert(_subdivisionsPerCountry[Country.DZ].Count == 58, "Number of subdivisions is wrong.");
        }
    }
}
