using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:SI is the entry for Slovenia in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO),
        /// which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Slovenia, ISO 3166-2 codes are defined for 200 municipalities and 12 urban municipalities.
        /// Each code consists of two parts, separated by a hyphen. The first part is SI, the ISO 3166-1 alpha-2 code of Slovenia.The second part is three digits,
        /// which is the municipality code used by the Statistical Office of the Republic of Slovenia:
        ///     001–147 (except 145): communes as from 1995 to 1998
        ///     148–193: communes created in 1998
        ///     194: municipality created in 2002
        ///     195–206: communes created in March 2006
        ///     207–211: communes created in June 2006
        ///     212–213: communes created in 2011
        /// The codes for all groups of communes are assigned in Slovenian alphabetical order, except Tišina and Šalovci(whose codes are assigned based on their former names,
        /// Cankova-Tišina and Hodoš Šalovci respectively) as well as Rogašovci(of which the former spelling was Rogačovci). Žalec, whose municipality code was 145,
        /// uses 190 after splitting into multiple municipalities in 1998. Ankaran was added in 2016.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:SI
        /// LastUpdated: 2023-03-21
        /// </remarks>
        internal static void ISO_3166_2_SI()
        {
            Add(Country.SI, "001", "Ajdovščina");
            Add(Country.SI, "213", "Ankaran");
            Add(Country.SI, "195", "Apače");
            Add(Country.SI, "002", "Beltinci");
            Add(Country.SI, "148", "Benedikt");
            Add(Country.SI, "149", "Bistrica ob Sotli");
            Add(Country.SI, "003", "Bled");
            Add(Country.SI, "150", "Bloke");
            Add(Country.SI, "004", "Bohinj");
            Add(Country.SI, "005", "Borovnica");
            Add(Country.SI, "006", "Bovec");
            Add(Country.SI, "151", "Braslovče");
            Add(Country.SI, "007", "Brda");
            Add(Country.SI, "008", "Brezovica");
            Add(Country.SI, "009", "Brežice");
            Add(Country.SI, "152", "Cankova");
            Add(Country.SI, "011", "Celje");
            Add(Country.SI, "012", "Cerklje na Gorenjskem");
            Add(Country.SI, "013", "Cerknica");
            Add(Country.SI, "014", "Cerkno");
            Add(Country.SI, "153", "Cerkvenjak");
            Add(Country.SI, "196", "Cirkulane");
            Add(Country.SI, "015", "Črenšovci");
            Add(Country.SI, "016", "Črna na Koroškem");
            Add(Country.SI, "017", "Črnomelj");
            Add(Country.SI, "018", "Destrnik");
            Add(Country.SI, "019", "Divača");
            Add(Country.SI, "154", "Dobje");
            Add(Country.SI, "020", "Dobrepolje");
            Add(Country.SI, "155", "Dobrna");
            Add(Country.SI, "021", "Dobrova-Polhov Gradec");
            Add(Country.SI, "156", "Dobrovnik");
            Add(Country.SI, "022", "Dol pri Ljubljani");
            Add(Country.SI, "157", "Dolenjske Toplice");
            Add(Country.SI, "023", "Domžale");
            Add(Country.SI, "024", "Dornava");
            Add(Country.SI, "025", "Dravograd");
            Add(Country.SI, "026", "Duplek");
            Add(Country.SI, "027", "Gorenja vas-Poljane");
            Add(Country.SI, "028", "Gorišnica");
            Add(Country.SI, "207", "Gorje");
            Add(Country.SI, "029", "Gornja Radgona");
            Add(Country.SI, "030", "Gornji Grad");
            Add(Country.SI, "031", "Gornji Petrovci");
            Add(Country.SI, "158", "Grad");
            Add(Country.SI, "032", "Grosuplje");
            Add(Country.SI, "159", "Hajdina");
            Add(Country.SI, "160", "Hoče-Slivnica");
            Add(Country.SI, "161", "Hodoš");
            Add(Country.SI, "162", "Horjul");
            Add(Country.SI, "034", "Hrastnik");
            Add(Country.SI, "035", "Hrpelje-Kozina");
            Add(Country.SI, "036", "Idrija");
            Add(Country.SI, "037", "Ig");
            Add(Country.SI, "038", "Ilirska Bistrica");
            Add(Country.SI, "039", "Ivančna Gorica");
            Add(Country.SI, "040", "Izola");
            Add(Country.SI, "041", "Jesenice");
            Add(Country.SI, "163", "Jezersko");
            Add(Country.SI, "042", "Juršinci");
            Add(Country.SI, "043", "Kamnik");
            Add(Country.SI, "044", "Kanal ob Soči");
            Add(Country.SI, "045", "Kidričevo");
            Add(Country.SI, "046", "Kobarid");
            Add(Country.SI, "047", "Kobilje");
            Add(Country.SI, "048", "Kočevje");
            Add(Country.SI, "049", "Komen");
            Add(Country.SI, "164", "Komenda");
            Add(Country.SI, "050", "Koper");
            Add(Country.SI, "197", "Kostanjevica na Krki");
            Add(Country.SI, "165", "Kostel");
            Add(Country.SI, "051", "Kozje");
            Add(Country.SI, "052", "Kranj");
            Add(Country.SI, "053", "Kranjska Gora");
            Add(Country.SI, "166", "Križevci");
            Add(Country.SI, "054", "Krško");
            Add(Country.SI, "055", "Kungota");
            Add(Country.SI, "056", "Kuzma");
            Add(Country.SI, "057", "Laško");
            Add(Country.SI, "058", "Lenart");
            Add(Country.SI, "059", "Lendava");
            Add(Country.SI, "060", "Litija");
            Add(Country.SI, "061", "Ljubljana");
            Add(Country.SI, "062", "Ljubno");
            Add(Country.SI, "063", "Ljutomer");
            Add(Country.SI, "208", "Log-Dragomer");
            Add(Country.SI, "064", "Logatec");
            Add(Country.SI, "065", "Loška dolina");
            Add(Country.SI, "066", "Loški Potok");
            Add(Country.SI, "167", "Lovrenc na Pohorju");
            Add(Country.SI, "067", "Luče");
            Add(Country.SI, "068", "Lukovica");
            Add(Country.SI, "069", "Majšperk");
            Add(Country.SI, "198", "Makole");
            Add(Country.SI, "070", "Maribor");
            Add(Country.SI, "168", "Markovci");
            Add(Country.SI, "071", "Medvode");
            Add(Country.SI, "072", "Mengeš");
            Add(Country.SI, "073", "Metlika");
            Add(Country.SI, "074", "Mežica");
            Add(Country.SI, "169", "Miklavž na Dravskem polju");
            Add(Country.SI, "075", "Miren-Kostanjevica");
            Add(Country.SI, "212", "Mirna");
            Add(Country.SI, "170", "Mirna Peč");
            Add(Country.SI, "076", "Mislinja");
            Add(Country.SI, "199", "Mokronog-Trebelno");
            Add(Country.SI, "077", "Moravče");
            Add(Country.SI, "078", "Moravske Toplice");
            Add(Country.SI, "079", "Mozirje");
            Add(Country.SI, "080", "Murska Sobota");
            Add(Country.SI, "081", "Muta");
            Add(Country.SI, "082", "Naklo");
            Add(Country.SI, "083", "Nazarje");
            Add(Country.SI, "084", "Nova Gorica");
            Add(Country.SI, "085", "Novo Mesto");
            Add(Country.SI, "086", "Odranci");
            Add(Country.SI, "171", "Oplotnica");
            Add(Country.SI, "087", "Ormož");
            Add(Country.SI, "088", "Osilnica");
            Add(Country.SI, "089", "Pesnica");
            Add(Country.SI, "090", "Piran");
            Add(Country.SI, "091", "Pivka");
            Add(Country.SI, "092", "Podčetrtek");
            Add(Country.SI, "172", "Podlehnik");
            Add(Country.SI, "093", "Podvelka");
            Add(Country.SI, "200", "Poljčane");
            Add(Country.SI, "173", "Polzela");
            Add(Country.SI, "094", "Postojna");
            Add(Country.SI, "174", "Prebold");
            Add(Country.SI, "095", "Preddvor");
            Add(Country.SI, "175", "Prevalje");
            Add(Country.SI, "096", "Ptuj");
            Add(Country.SI, "097", "Puconci");
            Add(Country.SI, "098", "Rače-Fram");
            Add(Country.SI, "099", "Radeče");
            Add(Country.SI, "100", "Radenci");
            Add(Country.SI, "101", "Radlje ob Dravi");
            Add(Country.SI, "102", "Radovljica");
            Add(Country.SI, "103", "Ravne na Koroškem");
            Add(Country.SI, "176", "Razkrižje");
            Add(Country.SI, "209", "Rečica ob Savinji");
            Add(Country.SI, "201", "Renče-Vogrsko");
            Add(Country.SI, "104", "Ribnica");
            Add(Country.SI, "177", "Ribnica na Pohorju");
            Add(Country.SI, "106", "Rogaška Slatina");
            Add(Country.SI, "105", "Rogašovci");
            Add(Country.SI, "107", "Rogatec");
            Add(Country.SI, "108", "Ruše");
            Add(Country.SI, "178", "Selnica ob Dravi");
            Add(Country.SI, "109", "Semič");
            Add(Country.SI, "110", "Sevnica");
            Add(Country.SI, "111", "Sežana");
            Add(Country.SI, "112", "Slovenj Gradec");
            Add(Country.SI, "113", "Slovenska Bistrica");
            Add(Country.SI, "114", "Slovenske Konjice");
            Add(Country.SI, "179", "Sodražica");
            Add(Country.SI, "180", "Solčava");
            Add(Country.SI, "202", "Središče ob Dravi");
            Add(Country.SI, "115", "Starše");
            Add(Country.SI, "203", "Straža");
            Add(Country.SI, "181", "Sveta Ana");
            Add(Country.SI, "204", "Sveta Trojica v Slovenskih goricah");
            Add(Country.SI, "182", "Sveti Andraž v Slovenskih goricah");
            Add(Country.SI, "116", "Sveti Jurij ob Ščavnici");
            Add(Country.SI, "210", "Sveti Jurij v Slovenskih goricah");
            Add(Country.SI, "205", "Sveti Tomaž");
            Add(Country.SI, "033", "Šalovci");
            Add(Country.SI, "183", "Šempeter-Vrtojba");
            Add(Country.SI, "117", "Šenčur");
            Add(Country.SI, "118", "Šentilj");
            Add(Country.SI, "119", "Šentjernej");
            Add(Country.SI, "120", "Šentjur");
            Add(Country.SI, "211", "Šentrupert");
            Add(Country.SI, "121", "Škocjan");
            Add(Country.SI, "122", "Škofja Loka");
            Add(Country.SI, "123", "Škofljica");
            Add(Country.SI, "124", "Šmarje pri Jelšah");
            Add(Country.SI, "206", "Šmarješke Toplice");
            Add(Country.SI, "125", "Šmartno ob Paki");
            Add(Country.SI, "194", "Šmartno pri Litiji");
            Add(Country.SI, "126", "Šoštanj");
            Add(Country.SI, "127", "Štore");
            Add(Country.SI, "184", "Tabor");
            Add(Country.SI, "010", "Tišina");
            Add(Country.SI, "128", "Tolmin");
            Add(Country.SI, "129", "Trbovlje");
            Add(Country.SI, "130", "Trebnje");
            Add(Country.SI, "185", "Trnovska Vas");
            Add(Country.SI, "186", "Trzin");
            Add(Country.SI, "131", "Tržič");
            Add(Country.SI, "132", "Turnišče");
            Add(Country.SI, "133", "Velenje");
            Add(Country.SI, "187", "Velika Polana");
            Add(Country.SI, "134", "Velike Lašče");
            Add(Country.SI, "188", "Veržej");
            Add(Country.SI, "135", "Videm");
            Add(Country.SI, "136", "Vipava");
            Add(Country.SI, "137", "Vitanje");
            Add(Country.SI, "138", "Vodice");
            Add(Country.SI, "139", "Vojnik");
            Add(Country.SI, "189", "Vransko");
            Add(Country.SI, "140", "Vrhnika");
            Add(Country.SI, "141", "Vuzenica");
            Add(Country.SI, "142", "Zagorje ob Savi");
            Add(Country.SI, "143", "Zavrč");
            Add(Country.SI, "144", "Zreče");
            Add(Country.SI, "190", "Žalec");
            Add(Country.SI, "146", "Železniki");
            Add(Country.SI, "191", "Žetale");
            Add(Country.SI, "147", "Žiri");
            Add(Country.SI, "192", "Žirovnica");
            Add(Country.SI, "193", "Žužemberk");

            Debug.Assert(_subdivisionsPerCountry[Country.SI].Count == 212, $"{Country.SI} Number of subdivisions is wrong.");
        }
    }
}
