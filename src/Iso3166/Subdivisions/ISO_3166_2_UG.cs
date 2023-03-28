using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:UG is the entry for Uganda in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization (ISO),
        /// which defines codes for the names of the principal subdivisions (e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Uganda, ISO 3166-2 codes are defined for 4 geographical regions, 134 districts, and 1 city(the capital of the country, Kampala).
        /// Each code consists of two parts, separated by a hyphen.The first part is UG, the ISO 3166-1 alpha-2 code of Uganda.The second part is either of the following:
        /// one letter: geographical regions
        /// three digits: districts and city
        /// For the districts, the first digit indicates the geographical region where the district is in:
        ///     1: Central
        ///     2: Eastern
        ///     3: Northern
        ///     4: Western
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:UG
        /// LastUpdated: 2023-03-20
        /// </remarks>
        internal static void ISO_3166_2_UG()
        {
            Add(Country.UG, "C", "Central");
            Add(Country.UG, "E", "Eastern");
            Add(Country.UG, "N", "Northern");
            Add(Country.UG, "W", "Western");
            Add(Country.UG, "314", "Abim");
            Add(Country.UG, "301", "Adjumani");
            Add(Country.UG, "322", "Agago");
            Add(Country.UG, "323", "Alebtong");
            Add(Country.UG, "315", "Amolatar");
            Add(Country.UG, "324", "Amudat");
            Add(Country.UG, "216", "Amuria");
            Add(Country.UG, "316", "Amuru");
            Add(Country.UG, "302", "Apac");
            Add(Country.UG, "303", "Arua");
            Add(Country.UG, "217", "Budaka");
            Add(Country.UG, "218", "Bududa");
            Add(Country.UG, "201", "Bugiri");
            Add(Country.UG, "235", "Bugweri");
            Add(Country.UG, "420", "Buhweju");
            Add(Country.UG, "117", "Buikwe");
            Add(Country.UG, "219", "Bukedea");
            Add(Country.UG, "118", "Bukomansibi");
            Add(Country.UG, "220", "Bukwo");
            Add(Country.UG, "225", "Bulambuli");
            Add(Country.UG, "416", "Buliisa");
            Add(Country.UG, "401", "Bundibugyo");
            Add(Country.UG, "430", "Bunyangabu");
            Add(Country.UG, "402", "Bushenyi");
            Add(Country.UG, "202", "Busia");
            Add(Country.UG, "221", "Butaleja");
            Add(Country.UG, "119", "Butambala");
            Add(Country.UG, "233", "Butebo");
            Add(Country.UG, "120", "Buvuma");
            Add(Country.UG, "226", "Buyende");
            Add(Country.UG, "317", "Dokolo");
            Add(Country.UG, "121", "Gomba");
            Add(Country.UG, "304", "Gulu");
            Add(Country.UG, "403", "Hoima");
            Add(Country.UG, "417", "Ibanda");
            Add(Country.UG, "203", "Iganga");
            Add(Country.UG, "418", "Isingiro");
            Add(Country.UG, "204", "Jinja");
            Add(Country.UG, "318", "Kaabong");
            Add(Country.UG, "404", "Kabale");
            Add(Country.UG, "405", "Kabarole");
            Add(Country.UG, "213", "Kaberamaido");
            Add(Country.UG, "427", "Kagadi");
            Add(Country.UG, "428", "Kakumiro");
            Add(Country.UG, "237", "Kalaki");
            Add(Country.UG, "101", "Kalangala");
            Add(Country.UG, "222", "Kaliro");
            Add(Country.UG, "122", "Kalungu");
            Add(Country.UG, "102", "Kampala");
            Add(Country.UG, "205", "Kamuli");
            Add(Country.UG, "413", "Kamwenge");
            Add(Country.UG, "414", "Kanungu");
            Add(Country.UG, "206", "Kapchorwa");
            Add(Country.UG, "236", "Kapelebyong");
            Add(Country.UG, "335", "Karenga");
            Add(Country.UG, "126", "Kasanda");
            Add(Country.UG, "406", "Kasese");
            Add(Country.UG, "207", "Katakwi");
            Add(Country.UG, "112", "Kayunga");
            Add(Country.UG, "433", "Kazo");
            Add(Country.UG, "407", "Kibaale");
            Add(Country.UG, "103", "Kiboga");
            Add(Country.UG, "227", "Kibuku");
            Add(Country.UG, "432", "Kikuube");
            Add(Country.UG, "419", "Kiruhura");
            Add(Country.UG, "421", "Kiryandongo");
            Add(Country.UG, "408", "Kisoro");
            Add(Country.UG, "434", "Kitagwenda");
            Add(Country.UG, "305", "Kitgum");
            Add(Country.UG, "319", "Koboko");
            Add(Country.UG, "325", "Kole");
            Add(Country.UG, "306", "Kotido");
            Add(Country.UG, "208", "Kumi");
            Add(Country.UG, "333", "Kwania");
            Add(Country.UG, "228", "Kween");
            Add(Country.UG, "123", "Kyankwanzi");
            Add(Country.UG, "422", "Kyegegwa");
            Add(Country.UG, "415", "Kyenjojo");
            Add(Country.UG, "125", "Kyotera");
            Add(Country.UG, "326", "Lamwo");
            Add(Country.UG, "307", "Lira");
            Add(Country.UG, "229", "Luuka");
            Add(Country.UG, "104", "Luwero");
            Add(Country.UG, "124", "Lwengo");
            Add(Country.UG, "114", "Lyantonde");
            Add(Country.UG, "336", "Madi-Okollo");
            Add(Country.UG, "223", "Manafwa");
            Add(Country.UG, "320", "Maracha");
            Add(Country.UG, "105", "Masaka");
            Add(Country.UG, "409", "Masindi");
            Add(Country.UG, "214", "Mayuge");
            Add(Country.UG, "209", "Mbale");
            Add(Country.UG, "410", "Mbarara");
            Add(Country.UG, "423", "Mitooma");
            Add(Country.UG, "115", "Mityana");
            Add(Country.UG, "308", "Moroto");
            Add(Country.UG, "309", "Moyo");
            Add(Country.UG, "106", "Mpigi");
            Add(Country.UG, "107", "Mubende");
            Add(Country.UG, "108", "Mukono");
            Add(Country.UG, "334", "Nabilatuk");
            Add(Country.UG, "311", "Nakapiripirit");
            Add(Country.UG, "116", "Nakaseke");
            Add(Country.UG, "109", "Nakasongola");
            Add(Country.UG, "230", "Namayingo");
            Add(Country.UG, "234", "Namisindwa");
            Add(Country.UG, "224", "Namutumba");
            Add(Country.UG, "327", "Napak");
            Add(Country.UG, "310", "Nebbi");
            Add(Country.UG, "231", "Ngora");
            Add(Country.UG, "424", "Ntoroko");
            Add(Country.UG, "411", "Ntungamo");
            Add(Country.UG, "328", "Nwoya");
            Add(Country.UG, "337", "Obongi");
            Add(Country.UG, "331", "Omoro");
            Add(Country.UG, "329", "Otuke");
            Add(Country.UG, "321", "Oyam");
            Add(Country.UG, "312", "Pader");
            Add(Country.UG, "332", "Pakwach");
            Add(Country.UG, "210", "Pallisa");
            Add(Country.UG, "110", "Rakai");
            Add(Country.UG, "429", "Rubanda");
            Add(Country.UG, "425", "Rubirizi");
            Add(Country.UG, "431", "Rukiga");
            Add(Country.UG, "412", "Rukungiri");
            Add(Country.UG, "435", "Rwampara");
            Add(Country.UG, "111", "Sembabule");
            Add(Country.UG, "232", "Serere");
            Add(Country.UG, "426", "Sheema");
            Add(Country.UG, "215", "Sironko");
            Add(Country.UG, "211", "Soroti");
            Add(Country.UG, "212", "Tororo");
            Add(Country.UG, "113", "Wakiso");
            Add(Country.UG, "313", "Yumbe");
            Add(Country.UG, "330", "Zombo");

            Debug.Assert(_subdivisionsPerCountry[Country.UG].Count == 139, $"{Country.UG} Number of subdivisions is wrong.");
        }
    }
}
