using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:EE is the entry for Estonia in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization (ISO),
        /// which defines codes for the names of the principal subdivisions (e.g., provinces or states) of all countries coded in ISO 3166-1.[1]
        /// Currently for Estonia, ISO 3166-2 codes are defined for 15 counties, 64 rural municipalities, and 15 urban municipalities.
        /// Each code consists of two parts, separated by a hyphen. The first part is EE, the ISO 3166-1 alpha-2 code of Estonia.
        /// The second part is two digits for counties or three digits for municipalities.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:EE
        /// LastUpdated: 2023-03-22
        /// </remarks>
        internal static void ISO_3166_2_EE()
        {
            Add(Country.EE, "37", "Harju");
            Add(Country.EE, "39", "Hiiu");
            Add(Country.EE, "45", "Ida-Viru");
            Add(Country.EE, "50", "Jõgeva");
            Add(Country.EE, "52", "Järva");
            Add(Country.EE, "56", "Lääne");
            Add(Country.EE, "60", "Lääne-Viru");
            Add(Country.EE, "64", "Põlva");
            Add(Country.EE, "68", "Pärnu");
            Add(Country.EE, "71", "Rapla");
            Add(Country.EE, "74", "Saare");
            Add(Country.EE, "79", "Tartu");
            Add(Country.EE, "81", "Valga");
            Add(Country.EE, "84", "Viljandi");
            Add(Country.EE, "87", "Võru");
            Add(Country.EE, "130", "Alutaguse");
            Add(Country.EE, "141", "Anija");
            Add(Country.EE, "142", "Antsla");
            Add(Country.EE, "171", "Elva");
            Add(Country.EE, "184", "Haapsalu");
            Add(Country.EE, "191", "Haljala");
            Add(Country.EE, "198", "Harku");
            Add(Country.EE, "205", "Hiiumaa");
            Add(Country.EE, "214", "Häädemeeste");
            Add(Country.EE, "245", "Jõelähtme");
            Add(Country.EE, "247", "Jõgeva");
            Add(Country.EE, "251", "Jõhvi");
            Add(Country.EE, "255", "Järva");
            Add(Country.EE, "272", "Kadrina");
            Add(Country.EE, "283", "Kambja");
            Add(Country.EE, "284", "Kanepi");
            Add(Country.EE, "291", "Kastre");
            Add(Country.EE, "293", "Kehtna");
            Add(Country.EE, "296", "Keila");
            Add(Country.EE, "303", "Kihnu");
            Add(Country.EE, "305", "Kiili");
            Add(Country.EE, "317", "Kohila");
            Add(Country.EE, "321", "Kohtla-Järve");
            Add(Country.EE, "338", "Kose");
            Add(Country.EE, "353", "Kuusalu");
            Add(Country.EE, "424", "Loksa");
            Add(Country.EE, "430", "Lääneranna");
            Add(Country.EE, "431", "Lääne-Harju");
            Add(Country.EE, "432", "Luunja");
            Add(Country.EE, "441", "Lääne-Nigula");
            Add(Country.EE, "442", "Lüganuse");
            Add(Country.EE, "446", "Maardu");
            Add(Country.EE, "478", "Muhu");
            Add(Country.EE, "480", "Mulgi");
            Add(Country.EE, "486", "Mustvee");
            Add(Country.EE, "503", "Märjamaa");
            Add(Country.EE, "511", "Narva");
            Add(Country.EE, "514", "Narva-Jõesuu");
            Add(Country.EE, "528", "Nõo");
            Add(Country.EE, "557", "Otepää");
            Add(Country.EE, "567", "Paide");
            Add(Country.EE, "586", "Peipsiääre");
            Add(Country.EE, "615", "Põhja-Sakala");
            Add(Country.EE, "618", "Põltsamaa");
            Add(Country.EE, "622", "Põlva");
            Add(Country.EE, "624", "Pärnu");
            Add(Country.EE, "638", "Põhja-Pärnumaa");
            Add(Country.EE, "651", "Raasiku");
            Add(Country.EE, "653", "Rae");
            Add(Country.EE, "661", "Rakvere");
            Add(Country.EE, "663", "Rakvere");
            Add(Country.EE, "668", "Rapla");
            Add(Country.EE, "689", "Ruhnu");
            Add(Country.EE, "698", "Rõuge");
            Add(Country.EE, "708", "Räpina");
            Add(Country.EE, "712", "Saarde");
            Add(Country.EE, "714", "Saaremaa");
            Add(Country.EE, "719", "Saku");
            Add(Country.EE, "726", "Saue");
            Add(Country.EE, "732", "Setomaa");
            Add(Country.EE, "735", "Sillamäe");
            Add(Country.EE, "784", "Tallinn");
            Add(Country.EE, "792", "Tapa");
            Add(Country.EE, "793", "Tartu");
            Add(Country.EE, "796", "Tartu");
            Add(Country.EE, "803", "Toila");
            Add(Country.EE, "809", "Tori");
            Add(Country.EE, "824", "Tõrva");
            Add(Country.EE, "834", "Türi");
            Add(Country.EE, "855", "Valga");
            Add(Country.EE, "890", "Viimsi");
            Add(Country.EE, "897", "Viljandi");
            Add(Country.EE, "899", "Viljandi");
            Add(Country.EE, "901", "Vinni");
            Add(Country.EE, "903", "Viru-Nigula");
            Add(Country.EE, "907", "Vormsi");
            Add(Country.EE, "917", "Võru");
            Add(Country.EE, "919", "Võru");
            Add(Country.EE, "928", "Väike-Maarja");

            Debug.Assert(_subdivisionsPerCountry[Country.EE].Count == 94, $"{Country.EE} Number of subdivisions is wrong.");
        }
    }
}
