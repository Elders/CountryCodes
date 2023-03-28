using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:CZ is the entry for Czechia in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization (ISO),
        /// which defines codes for the names of the principal subdivisions (e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently, ISO 3166-2 codes are defined for two levels of subdivisions within the country:
        ///     13 regions and 1 capital city
        ///     76 districts
        /// Each code consists of two parts, separated by a hyphen.The first part is CZ, the ISO 3166-1 alpha-2 code for the country. The second part is either of the following:
        ///     two digits: regions
        ///     three characters (two digits followed by a digit or a letter): districts
        /// For the districts, the first two digits indicate the region that the district is in (based on the original NUTS code of the region):
        ///     10 and 11: Prague
        ///     20: Central Bohemian Region
        ///     31: South Bohemian Region
        ///     32: Plzeň Region
        ///     41: Karlovy Vary Region
        ///     42: Ústí nad Labem Region
        ///     51: Liberec Region
        ///     52: Hradec Králové Region
        ///     53: Pardubice Region
        ///     63: Vysočina Region
        ///     64: South Moravian Region
        ///     71: Olomouc Region
        ///     72: Zlín Region
        ///     80: Moravian-Silesian Region
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:CZ
        /// LastUpdated: 2023-03-22
        /// </remarks>
        internal static void ISO_3166_2_CZ()
        {
            Add(Country.CZ, "64", "South Moravia");
            Add(Country.CZ, "31", "South Bohemia");
            Add(Country.CZ, "41", "Karlovy Vary");
            Add(Country.CZ, "52", "Hradec Králové");
            Add(Country.CZ, "51", "Liberec");
            Add(Country.CZ, "80", "Moravia-Silesia");
            Add(Country.CZ, "71", "Olomouc");
            Add(Country.CZ, "53", "Pardubice");
            Add(Country.CZ, "32", "Plzeň");
            Add(Country.CZ, "10", "Prague");
            Add(Country.CZ, "20", "Central Bohemia");
            Add(Country.CZ, "42", "Ústí nad Labem");
            Add(Country.CZ, "63", "Vysočina");
            Add(Country.CZ, "72", "Zlín");
            Add(Country.CZ, "201", "Benešov");
            Add(Country.CZ, "202", "Beroun");
            Add(Country.CZ, "641", "Blansko");
            Add(Country.CZ, "642", "Brno-město");
            Add(Country.CZ, "643", "Brno-venkov");
            Add(Country.CZ, "801", "Bruntál");
            Add(Country.CZ, "644", "Břeclav");
            Add(Country.CZ, "511", "Česká Lípa");
            Add(Country.CZ, "311", "České Budějovice");
            Add(Country.CZ, "312", "Český Krumlov");
            Add(Country.CZ, "421", "Děčín");
            Add(Country.CZ, "321", "Domažlice");
            Add(Country.CZ, "802", "Frýdek-Místek");
            Add(Country.CZ, "631", "Havlíčkův Brod");
            Add(Country.CZ, "645", "Hodonín");
            Add(Country.CZ, "521", "Hradec Králové");
            Add(Country.CZ, "411", "Cheb");
            Add(Country.CZ, "422", "Chomutov");
            Add(Country.CZ, "531", "Chrudim");
            Add(Country.CZ, "512", "Jablonec nad Nisou");
            Add(Country.CZ, "711", "Jeseník");
            Add(Country.CZ, "522", "Jičín");
            Add(Country.CZ, "632", "Jihlava");
            Add(Country.CZ, "313", "Jindřichův Hradec");
            Add(Country.CZ, "412", "Karlovy Vary");
            Add(Country.CZ, "803", "Karviná");
            Add(Country.CZ, "203", "Kladno");
            Add(Country.CZ, "322", "Klatovy");
            Add(Country.CZ, "204", "Kolín");
            Add(Country.CZ, "721", "Kroměříž");
            Add(Country.CZ, "205", "Kutná Hora");
            Add(Country.CZ, "513", "Liberec");
            Add(Country.CZ, "423", "Litoměřice");
            Add(Country.CZ, "424", "Louny");
            Add(Country.CZ, "206", "Mělník");
            Add(Country.CZ, "207", "Mladá Boleslav");
            Add(Country.CZ, "425", "Most");
            Add(Country.CZ, "523", "Náchod");
            Add(Country.CZ, "804", "Nový Jičín");
            Add(Country.CZ, "208", "Nymburk");
            Add(Country.CZ, "712", "Olomouc");
            Add(Country.CZ, "805", "Opava");
            Add(Country.CZ, "806", "Ostrava-město");
            Add(Country.CZ, "532", "Pardubice");
            Add(Country.CZ, "633", "Pelhřimov");
            Add(Country.CZ, "314", "Písek");
            Add(Country.CZ, "324", "Plzeň-jih");
            Add(Country.CZ, "323", "Plzeň-město");
            Add(Country.CZ, "325", "Plzeň-sever");
            Add(Country.CZ, "209", "Praha-východ");
            Add(Country.CZ, "20A", "Praha-západ");
            Add(Country.CZ, "315", "Prachatice");
            Add(Country.CZ, "713", "Prostějov");
            Add(Country.CZ, "714", "Přerov");
            Add(Country.CZ, "20B", "Příbram");
            Add(Country.CZ, "20C", "Rakovník");
            Add(Country.CZ, "326", "Rokycany");
            Add(Country.CZ, "524", "Rychnov nad Kněžnou");
            Add(Country.CZ, "514", "Semily");
            Add(Country.CZ, "413", "Sokolov");
            Add(Country.CZ, "316", "Strakonice");
            Add(Country.CZ, "533", "Svitavy");
            Add(Country.CZ, "715", "Šumperk");
            Add(Country.CZ, "317", "Tábor");
            Add(Country.CZ, "327", "Tachov");
            Add(Country.CZ, "426", "Teplice");
            Add(Country.CZ, "525", "Trutnov");
            Add(Country.CZ, "634", "Třebíč");
            Add(Country.CZ, "722", "Uherské Hradiště");
            Add(Country.CZ, "427", "Ústí nad Labem");
            Add(Country.CZ, "534", "Ústí nad Orlicí");
            Add(Country.CZ, "723", "Vsetín");
            Add(Country.CZ, "646", "Vyškov");
            Add(Country.CZ, "724", "Zlín");
            Add(Country.CZ, "647", "Znojmo");
            Add(Country.CZ, "635", "Žďár nad Sázavou");

            Debug.Assert(_subdivisionsPerCountry[Country.CZ].Count == 90, $"{Country.CZ} Number of subdivisions is wrong.");
        }
    }
}
