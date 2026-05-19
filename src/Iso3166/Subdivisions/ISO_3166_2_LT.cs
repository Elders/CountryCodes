using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:LT is the entry for Lithuania in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO),
        /// which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Lithuania, ISO 3166-2 codes are defined for 10 counties, 7 city municipalities, 44 district municipalities and 9 municipalities.
        /// Each code consists of two parts, separated by a hyphen.The first part is LT, the ISO 3166-1 alpha-2 code of Lithuania.The second part is either of the following:
        ///     two letters: counties
        ///     two digits: city municipalities, district municipalities and municipalities
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:LT
        /// LastUpdated: 2023-03-24
        /// </remarks>
        internal static void ISO_3166_2_LT()
        {
            Add(Country.LT, "AL", "Alytus County");
            Add(Country.LT, "KU", "Kaunas County");
            Add(Country.LT, "KL", "Klaipėda County");
            Add(Country.LT, "MR", "Marijampolė County");
            Add(Country.LT, "PN", "Panevėžys County");
            Add(Country.LT, "SA", "Šiauliai County");
            Add(Country.LT, "TA", "Tauragė County");
            Add(Country.LT, "TE", "Telšiai County");
            Add(Country.LT, "UT", "Utena County");
            Add(Country.LT, "VL", "Vilnius County");
            Add(Country.LT, "01", "Akmenė");
            Add(Country.LT, "02", "Alytaus miestas");
            Add(Country.LT, "03", "Alytus");
            Add(Country.LT, "04", "Anykščiai");
            Add(Country.LT, "05", "Birštonas");
            Add(Country.LT, "06", "Biržai");
            Add(Country.LT, "07", "Druskininkai");
            Add(Country.LT, "08", "Elektrėnai");
            Add(Country.LT, "09", "Ignalina");
            Add(Country.LT, "10", "Jonava");
            Add(Country.LT, "11", "Joniškis");
            Add(Country.LT, "12", "Jurbarkas");
            Add(Country.LT, "13", "Kaišiadorys");
            Add(Country.LT, "14", "Kalvarija");
            Add(Country.LT, "15", "Kauno miestas");
            Add(Country.LT, "16", "Kaunas");
            Add(Country.LT, "17", "Kazlų Rūdos");
            Add(Country.LT, "18", "Kėdainiai");
            Add(Country.LT, "19", "Kelmė");
            Add(Country.LT, "20", "Klaipėdos miestas");
            Add(Country.LT, "21", "Klaipėda");
            Add(Country.LT, "22", "Kretinga");
            Add(Country.LT, "23", "Kupiškis");
            Add(Country.LT, "24", "Lazdijai");
            Add(Country.LT, "25", "Marijampolė");
            Add(Country.LT, "26", "Mažeikiai");
            Add(Country.LT, "27", "Molėtai");
            Add(Country.LT, "28", "Neringa");
            Add(Country.LT, "29", "Pagėgiai");
            Add(Country.LT, "30", "Pakruojis");
            Add(Country.LT, "31", "Palangos miestas");
            Add(Country.LT, "32", "Panevėžio miestas");
            Add(Country.LT, "33", "Panevėžys");
            Add(Country.LT, "34", "Pasvalys");
            Add(Country.LT, "35", "Plungė");
            Add(Country.LT, "36", "Prienai");
            Add(Country.LT, "37", "Radviliškis");
            Add(Country.LT, "38", "Raseiniai");
            Add(Country.LT, "39", "Rietavas");
            Add(Country.LT, "40", "Rokiškis");
            Add(Country.LT, "41", "Šakiai");
            Add(Country.LT, "42", "Šalčininkai");
            Add(Country.LT, "43", "Šiaulių miestas");
            Add(Country.LT, "44", "Šiauliai");
            Add(Country.LT, "45", "Šilalė");
            Add(Country.LT, "46", "Šilutė");
            Add(Country.LT, "47", "Širvintos");
            Add(Country.LT, "48", "Skuodas");
            Add(Country.LT, "49", "Švenčionys");
            Add(Country.LT, "50", "Tauragė");
            Add(Country.LT, "51", "Telšiai");
            Add(Country.LT, "52", "Trakai");
            Add(Country.LT, "53", "Ukmergė");
            Add(Country.LT, "54", "Utena");
            Add(Country.LT, "55", "Varėna");
            Add(Country.LT, "56", "Vilkaviškis");
            Add(Country.LT, "57", "Vilniaus miestas");
            Add(Country.LT, "58", "Vilnius");
            Add(Country.LT, "59", "Visaginas");
            Add(Country.LT, "60", "Zarasai");

            Debug.Assert(_subdivisionsPerCountry[Country.LT].Count == 70, $"{Country.LT} Number of subdivisions is wrong.");
        }
    }
}
