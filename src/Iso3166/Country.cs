using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;

namespace Elders.Iso3166
{
    /// <summary>
    ///     Represents countries and coresponding subdivisions according to ISO 3166." />
    /// </summary>
    /// <remarks>
    ///     https://en.wikipedia.org/wiki/List_of_ISO_3166_country_codes
    /// </remarks>
    [Serializable]
    [DataContract(Name = "iso-3166-country")]
    public struct Country : IEquatable<Country>
    {
        private static readonly Dictionary<int, CountryTableEntry> _allCountries = new Dictionary<int, CountryTableEntry>();

        [DataMember(Order = 0)]
        private int _countryNumericCode;

        static Country()
        {
            _allCountries[004] = new CountryTableEntry("Afghanistan", "AF", "AFG", 004);
            _allCountries[248] = new CountryTableEntry("Åland Islands", "AX", "ALA", 248);
            _allCountries[008] = new CountryTableEntry("Albania", "AL", "ALB", 008);
            _allCountries[012] = new CountryTableEntry("Algeria", "DZ", "DZA", 012);
            _allCountries[016] = new CountryTableEntry("American Samoa", "AS", "ASM", 016);
            _allCountries[020] = new CountryTableEntry("Andorra", "AD", "AND", 020);
            _allCountries[024] = new CountryTableEntry("Angola", "AO", "AGO", 024);
            _allCountries[660] = new CountryTableEntry("Anguilla", "AI", "AIA", 660);
            _allCountries[010] = new CountryTableEntry("Antarctica", "AQ", "ATA", 010);
            _allCountries[028] = new CountryTableEntry("Antigua and Barbuda", "AG", "ATG", 028);
            _allCountries[032] = new CountryTableEntry("Argentina", "AR", "ARG", 032);
            _allCountries[051] = new CountryTableEntry("Armenia", "AM", "ARM", 051);
            _allCountries[533] = new CountryTableEntry("Aruba", "AW", "ABW", 533);
            _allCountries[036] = new CountryTableEntry("Australia", "AU", "AUS", 036);
            _allCountries[040] = new CountryTableEntry("Austria", "AT", "AUT", 040);
            _allCountries[031] = new CountryTableEntry("Azerbaijan", "AZ", "AZE", 031);
            _allCountries[044] = new CountryTableEntry("Bahamas", "BS", "BHS", 044);
            _allCountries[048] = new CountryTableEntry("Bahrain", "BH", "BHR", 048);
            _allCountries[050] = new CountryTableEntry("Bangladesh", "BD", "BGD", 050);
            _allCountries[052] = new CountryTableEntry("Barbados", "BB", "BRB", 052);
            _allCountries[112] = new CountryTableEntry("Belarus", "BY", "BLR", 112);
            _allCountries[056] = new CountryTableEntry("Belgium", "BE", "BEL", 056);
            _allCountries[084] = new CountryTableEntry("Belize", "BZ", "BLZ", 084);
            _allCountries[204] = new CountryTableEntry("Benin", "BJ", "BEN", 204);
            _allCountries[060] = new CountryTableEntry("Bermuda", "BM", "BMU", 060);
            _allCountries[064] = new CountryTableEntry("Bhutan", "BT", "BTN", 064);
            _allCountries[068] = new CountryTableEntry("Bolivia, Plurinational State of", "BO", "BOL", 068);
            _allCountries[535] = new CountryTableEntry("Bonaire, Sint Eustatius and Saba", "BQ", "BES", 535);
            _allCountries[070] = new CountryTableEntry("Bosnia and Herzegovina", "BA", "BIH", 070);
            _allCountries[072] = new CountryTableEntry("Botswana", "BW", "BWA", 072);
            _allCountries[074] = new CountryTableEntry("Bouvet Island", "BV", "BVT", 074);
            _allCountries[076] = new CountryTableEntry("Brazil", "BR", "BRA", 076);
            _allCountries[086] = new CountryTableEntry("British Indian Ocean Territory", "IO", "IOT", 086);
            _allCountries[096] = new CountryTableEntry("Brunei Darussalam", "BN", "BRN", 096);
            _allCountries[100] = new CountryTableEntry("Bulgaria", "BG", "BGR", 100);
            _allCountries[854] = new CountryTableEntry("Burkina Faso", "BF", "BFA", 854);
            _allCountries[108] = new CountryTableEntry("Burundi", "BI", "BDI", 108);
            _allCountries[116] = new CountryTableEntry("Cambodia", "KH", "KHM", 116);
            _allCountries[120] = new CountryTableEntry("Cameroon", "CM", "CMR", 120);
            _allCountries[124] = new CountryTableEntry("Canada", "CA", "CAN", 124);
            _allCountries[132] = new CountryTableEntry("Cabo Verde", "CV", "CPV", 132);
            _allCountries[136] = new CountryTableEntry("Cayman Islands", "KY", "CYM", 136);
            _allCountries[140] = new CountryTableEntry("Central African Republic", "CF", "CAF", 140);
            _allCountries[148] = new CountryTableEntry("Chad", "TD", "TCD", 148);
            _allCountries[152] = new CountryTableEntry("Chile", "CL", "CHL", 152);
            _allCountries[156] = new CountryTableEntry("China", "CN", "CHN", 156);
            _allCountries[162] = new CountryTableEntry("Christmas Island", "CX", "CXR", 162);
            _allCountries[166] = new CountryTableEntry("Cocos (Keeling) Islands", "CC", "CCK", 166);
            _allCountries[170] = new CountryTableEntry("Colombia", "CO", "COL", 170);
            _allCountries[174] = new CountryTableEntry("Comoros", "KM", "COM", 174);
            _allCountries[178] = new CountryTableEntry("Congo", "CG", "COG", 178);
            _allCountries[180] = new CountryTableEntry("Congo, the Democratic Republic of the", "CD", "COD", 180);
            _allCountries[184] = new CountryTableEntry("Cook Islands", "CK", "COK", 184);
            _allCountries[188] = new CountryTableEntry("Costa Rica", "CR", "CRI", 188);
            _allCountries[384] = new CountryTableEntry("Côte d'Ivoire", "CI", "CIV", 384);
            _allCountries[191] = new CountryTableEntry("Croatia", "HR", "HRV", 191);
            _allCountries[192] = new CountryTableEntry("Cuba", "CU", "CUB", 192);
            _allCountries[531] = new CountryTableEntry("Curaçao", "CW", "CUW", 531);
            _allCountries[196] = new CountryTableEntry("Cyprus", "CY", "CYP", 196);
            _allCountries[203] = new CountryTableEntry("Czech Republic", "CZ", "CZE", 203);
            _allCountries[208] = new CountryTableEntry("Denmark", "DK", "DNK", 208);
            _allCountries[262] = new CountryTableEntry("Djibouti", "DJ", "DJI", 262);
            _allCountries[212] = new CountryTableEntry("Dominica", "DM", "DMA", 212);
            _allCountries[214] = new CountryTableEntry("Dominican Republic", "DO", "DOM", 214);
            _allCountries[218] = new CountryTableEntry("Ecuador", "EC", "ECU", 218);
            _allCountries[818] = new CountryTableEntry("Egypt", "EG", "EGY", 818);
            _allCountries[222] = new CountryTableEntry("El Salvador", "SV", "SLV", 222);
            _allCountries[226] = new CountryTableEntry("Equatorial Guinea", "GQ", "GNQ", 226);
            _allCountries[232] = new CountryTableEntry("Eritrea", "ER", "ERI", 232);
            _allCountries[233] = new CountryTableEntry("Estonia", "EE", "EST", 233);
            _allCountries[231] = new CountryTableEntry("Ethiopia", "ET", "ETH", 231);
            _allCountries[238] = new CountryTableEntry("Falkland Islands (Malvinas)", "FK", "FLK", 238);
            _allCountries[234] = new CountryTableEntry("Faroe Islands", "FO", "FRO", 234);
            _allCountries[242] = new CountryTableEntry("Fiji", "FJ", "FJI", 242);
            _allCountries[246] = new CountryTableEntry("Finland", "FI", "FIN", 246);
            _allCountries[250] = new CountryTableEntry("France", "FR", "FRA", 250);
            _allCountries[254] = new CountryTableEntry("French Guiana", "GF", "GUF", 254);
            _allCountries[258] = new CountryTableEntry("French Polynesia", "PF", "PYF", 258);
            _allCountries[260] = new CountryTableEntry("French Southern Territories", "TF", "ATF", 260);
            _allCountries[266] = new CountryTableEntry("Gabon", "GA", "GAB", 266);
            _allCountries[270] = new CountryTableEntry("Gambia", "GM", "GMB", 270);
            _allCountries[268] = new CountryTableEntry("Georgia", "GE", "GEO", 268);
            _allCountries[276] = new CountryTableEntry("Germany", "DE", "DEU", 276);
            _allCountries[288] = new CountryTableEntry("Ghana", "GH", "GHA", 288);
            _allCountries[292] = new CountryTableEntry("Gibraltar", "GI", "GIB", 292);
            _allCountries[300] = new CountryTableEntry("Greece", "GR", "GRC", 300);
            _allCountries[304] = new CountryTableEntry("Greenland", "GL", "GRL", 304);
            _allCountries[308] = new CountryTableEntry("Grenada", "GD", "GRD", 308);
            _allCountries[312] = new CountryTableEntry("Guadeloupe", "GP", "GLP", 312);
            _allCountries[316] = new CountryTableEntry("Guam", "GU", "GUM", 316);
            _allCountries[320] = new CountryTableEntry("Guatemala", "GT", "GTM", 320);
            _allCountries[831] = new CountryTableEntry("Guernsey", "GG", "GGY", 831);
            _allCountries[324] = new CountryTableEntry("Guinea", "GN", "GIN", 324);
            _allCountries[624] = new CountryTableEntry("Guinea-Bissau", "GW", "GNB", 624);
            _allCountries[328] = new CountryTableEntry("Guyana", "GY", "GUY", 328);
            _allCountries[332] = new CountryTableEntry("Haiti", "HT", "HTI", 332);
            _allCountries[334] = new CountryTableEntry("Heard Island and McDonald Islands", "HM", "HMD", 334);
            _allCountries[336] = new CountryTableEntry("Holy See (Vatican City State)", "VA", "VAT", 336);
            _allCountries[340] = new CountryTableEntry("Honduras", "HN", "HND", 340);
            _allCountries[344] = new CountryTableEntry("Hong Kong", "HK", "HKG", 344);
            _allCountries[348] = new CountryTableEntry("Hungary", "HU", "HUN", 348);
            _allCountries[352] = new CountryTableEntry("Iceland", "IS", "ISL", 352);
            _allCountries[356] = new CountryTableEntry("India", "IN", "IND", 356);
            _allCountries[360] = new CountryTableEntry("Indonesia", "ID", "IDN", 360);
            _allCountries[364] = new CountryTableEntry("Iran, Islamic Republic of", "IR", "IRN", 364);
            _allCountries[368] = new CountryTableEntry("Iraq", "IQ", "IRQ", 368);
            _allCountries[372] = new CountryTableEntry("Ireland", "IE", "IRL", 372);
            _allCountries[833] = new CountryTableEntry("Isle of Man", "IM", "IMN", 833);
            _allCountries[376] = new CountryTableEntry("Israel", "IL", "ISR", 376);
            _allCountries[380] = new CountryTableEntry("Italy", "IT", "ITA", 380);
            _allCountries[388] = new CountryTableEntry("Jamaica", "JM", "JAM", 388);
            _allCountries[392] = new CountryTableEntry("Japan", "JP", "JPN", 392);
            _allCountries[832] = new CountryTableEntry("Jersey", "JE", "JEY", 832);
            _allCountries[400] = new CountryTableEntry("Jordan", "JO", "JOR", 400);
            _allCountries[398] = new CountryTableEntry("Kazakhstan", "KZ", "KAZ", 398);
            _allCountries[404] = new CountryTableEntry("Kenya", "KE", "KEN", 404);
            _allCountries[296] = new CountryTableEntry("Kiribati", "KI", "KIR", 296);
            _allCountries[408] = new CountryTableEntry("Korea, Democratic People's Republic of", "KP", "PRK", 408);
            _allCountries[410] = new CountryTableEntry("Korea, Republic of", "KR", "KOR", 410);
            _allCountries[414] = new CountryTableEntry("Kuwait", "KW", "KWT", 414);
            _allCountries[417] = new CountryTableEntry("Kyrgyzstan", "KG", "KGZ", 417);
            _allCountries[418] = new CountryTableEntry("Lao People's Democratic Republic", "LA", "LAO", 418);
            _allCountries[428] = new CountryTableEntry("Latvia", "LV", "LVA", 428);
            _allCountries[422] = new CountryTableEntry("Lebanon", "LB", "LBN", 422);
            _allCountries[426] = new CountryTableEntry("Lesotho", "LS", "LSO", 426);
            _allCountries[430] = new CountryTableEntry("Liberia", "LR", "LBR", 430);
            _allCountries[434] = new CountryTableEntry("Libya", "LY", "LBY", 434);
            _allCountries[438] = new CountryTableEntry("Liechtenstein", "LI", "LIE", 438);
            _allCountries[440] = new CountryTableEntry("Lithuania", "LT", "LTU", 440);
            _allCountries[442] = new CountryTableEntry("Luxembourg", "LU", "LUX", 442);
            _allCountries[446] = new CountryTableEntry("Macao", "MO", "MAC", 446);
            _allCountries[807] = new CountryTableEntry("Macedonia, the former Yugoslav Republic of", "MK", "MKD", 807);
            _allCountries[450] = new CountryTableEntry("Madagascar", "MG", "MDG", 450);
            _allCountries[454] = new CountryTableEntry("Malawi", "MW", "MWI", 454);
            _allCountries[458] = new CountryTableEntry("Malaysia", "MY", "MYS", 458);
            _allCountries[462] = new CountryTableEntry("Maldives", "MV", "MDV", 462);
            _allCountries[466] = new CountryTableEntry("Mali", "ML", "MLI", 466);
            _allCountries[470] = new CountryTableEntry("Malta", "MT", "MLT", 470);
            _allCountries[584] = new CountryTableEntry("Marshall Islands", "MH", "MHL", 584);
            _allCountries[474] = new CountryTableEntry("Martinique", "MQ", "MTQ", 474);
            _allCountries[478] = new CountryTableEntry("Mauritania", "MR", "MRT", 478);
            _allCountries[480] = new CountryTableEntry("Mauritius", "MU", "MUS", 480);
            _allCountries[175] = new CountryTableEntry("Mayotte", "YT", "MYT", 175);
            _allCountries[484] = new CountryTableEntry("Mexico", "MX", "MEX", 484);
            _allCountries[583] = new CountryTableEntry("Micronesia, Federated States of", "FM", "FSM", 583);
            _allCountries[498] = new CountryTableEntry("Moldova, Republic of", "MD", "MDA", 498);
            _allCountries[492] = new CountryTableEntry("Monaco", "MC", "MCO", 492);
            _allCountries[496] = new CountryTableEntry("Mongolia", "MN", "MNG", 496);
            _allCountries[499] = new CountryTableEntry("Montenegro", "ME", "MNE", 499);
            _allCountries[500] = new CountryTableEntry("Montserrat", "MS", "MSR", 500);
            _allCountries[504] = new CountryTableEntry("Morocco", "MA", "MAR", 504);
            _allCountries[508] = new CountryTableEntry("Mozambique", "MZ", "MOZ", 508);
            _allCountries[104] = new CountryTableEntry("Myanmar", "MM", "MMR", 104);
            _allCountries[516] = new CountryTableEntry("Namibia", "NA", "NAM", 516);
            _allCountries[520] = new CountryTableEntry("Nauru", "NR", "NRU", 520);
            _allCountries[524] = new CountryTableEntry("Nepal", "NP", "NPL", 524);
            _allCountries[528] = new CountryTableEntry("Netherlands", "NL", "NLD", 528);
            _allCountries[540] = new CountryTableEntry("New Caledonia", "NC", "NCL", 540);
            _allCountries[554] = new CountryTableEntry("New Zealand", "NZ", "NZL", 554);
            _allCountries[558] = new CountryTableEntry("Nicaragua", "NI", "NIC", 558);
            _allCountries[562] = new CountryTableEntry("Niger", "NE", "NER", 562);
            _allCountries[566] = new CountryTableEntry("Nigeria", "NG", "NGA", 566);
            _allCountries[570] = new CountryTableEntry("Niue", "NU", "NIU", 570);
            _allCountries[574] = new CountryTableEntry("Norfolk Island", "NF", "NFK", 574);
            _allCountries[580] = new CountryTableEntry("Northern Mariana Islands", "MP", "MNP", 580);
            _allCountries[578] = new CountryTableEntry("Norway", "NO", "NOR", 578);
            _allCountries[512] = new CountryTableEntry("Oman", "OM", "OMN", 512);
            _allCountries[586] = new CountryTableEntry("Pakistan", "PK", "PAK", 586);
            _allCountries[585] = new CountryTableEntry("Palau", "PW", "PLW", 585);
            _allCountries[275] = new CountryTableEntry("Palestine, State of", "PS", "PSE", 275);
            _allCountries[591] = new CountryTableEntry("Panama", "PA", "PAN", 591);
            _allCountries[598] = new CountryTableEntry("Papua New Guinea", "PG", "PNG", 598);
            _allCountries[600] = new CountryTableEntry("Paraguay", "PY", "PRY", 600);
            _allCountries[604] = new CountryTableEntry("Peru", "PE", "PER", 604);
            _allCountries[608] = new CountryTableEntry("Philippines", "PH", "PHL", 608);
            _allCountries[612] = new CountryTableEntry("Pitcairn", "PN", "PCN", 612);
            _allCountries[616] = new CountryTableEntry("Poland", "PL", "POL", 616);
            _allCountries[620] = new CountryTableEntry("Portugal", "PT", "PRT", 620);
            _allCountries[630] = new CountryTableEntry("Puerto Rico", "PR", "PRI", 630);
            _allCountries[634] = new CountryTableEntry("Qatar", "QA", "QAT", 634);
            _allCountries[638] = new CountryTableEntry("Réunion", "RE", "REU", 638);
            _allCountries[642] = new CountryTableEntry("Romania", "RO", "ROU", 642);
            _allCountries[643] = new CountryTableEntry("Russian Federation", "RU", "RUS", 643);
            _allCountries[646] = new CountryTableEntry("Rwanda", "RW", "RWA", 646);
            _allCountries[652] = new CountryTableEntry("Saint Barthélemy", "BL", "BLM", 652);
            _allCountries[654] = new CountryTableEntry("Saint Helena, Ascension and Tristan da Cunha", "SH", "SHN", 654);
            _allCountries[659] = new CountryTableEntry("Saint Kitts and Nevis", "KN", "KNA", 659);
            _allCountries[662] = new CountryTableEntry("Saint Lucia", "LC", "LCA", 662);
            _allCountries[663] = new CountryTableEntry("Saint Martin (French part)", "MF", "MAF", 663);
            _allCountries[666] = new CountryTableEntry("Saint Pierre and Miquelon", "PM", "SPM", 666);
            _allCountries[670] = new CountryTableEntry("Saint Vincent and the Grenadines", "VC", "VCT", 670);
            _allCountries[882] = new CountryTableEntry("Samoa", "WS", "WSM", 882);
            _allCountries[674] = new CountryTableEntry("San Marino", "SM", "SMR", 674);
            _allCountries[678] = new CountryTableEntry("Sao Tome and Principe", "ST", "STP", 678);
            _allCountries[682] = new CountryTableEntry("Saudi Arabia", "SA", "SAU", 682);
            _allCountries[686] = new CountryTableEntry("Senegal", "SN", "SEN", 686);
            _allCountries[688] = new CountryTableEntry("Serbia", "RS", "SRB", 688);
            _allCountries[690] = new CountryTableEntry("Seychelles", "SC", "SYC", 690);
            _allCountries[694] = new CountryTableEntry("Sierra Leone", "SL", "SLE", 694);
            _allCountries[702] = new CountryTableEntry("Singapore", "SG", "SGP", 702);
            _allCountries[534] = new CountryTableEntry("Sint Maarten (Dutch part)", "SX", "SXM", 534);
            _allCountries[703] = new CountryTableEntry("Slovakia", "SK", "SVK", 703);
            _allCountries[705] = new CountryTableEntry("Slovenia", "SI", "SVN", 705);
            _allCountries[090] = new CountryTableEntry("Solomon Islands", "SB", "SLB", 090);
            _allCountries[706] = new CountryTableEntry("Somalia", "SO", "SOM", 706);
            _allCountries[710] = new CountryTableEntry("South Africa", "ZA", "ZAF", 710);
            _allCountries[239] = new CountryTableEntry("South Georgia and the South Sandwich Islands", "GS", "SGS", 239);
            _allCountries[728] = new CountryTableEntry("South Sudan", "SS", "SSD", 728);
            _allCountries[724] = new CountryTableEntry("Spain", "ES", "ESP", 724);
            _allCountries[144] = new CountryTableEntry("Sri Lanka", "LK", "LKA", 144);
            _allCountries[729] = new CountryTableEntry("Sudan", "SD", "SDN", 729);
            _allCountries[740] = new CountryTableEntry("SuriName", "SR", "SUR", 740);
            _allCountries[744] = new CountryTableEntry("Svalbard and Jan Mayen", "SJ", "SJM", 744);
            _allCountries[748] = new CountryTableEntry("Swaziland", "SZ", "SWZ", 748);
            _allCountries[752] = new CountryTableEntry("Sweden", "SE", "SWE", 752);
            _allCountries[756] = new CountryTableEntry("Switzerland", "CH", "CHE", 756);
            _allCountries[760] = new CountryTableEntry("Syrian Arab Republic", "SY", "SYR", 760);
            _allCountries[158] = new CountryTableEntry("Taiwan, Province of China", "TW", "TWN", 158);
            _allCountries[762] = new CountryTableEntry("Tajikistan", "TJ", "TJK", 762);
            _allCountries[834] = new CountryTableEntry("Tanzania, United Republic of", "TZ", "TZA", 834);
            _allCountries[764] = new CountryTableEntry("Thailand", "TH", "THA", 764);
            _allCountries[626] = new CountryTableEntry("Timor-Leste", "TL", "TLS", 626);
            _allCountries[768] = new CountryTableEntry("Togo", "TG", "TGO", 768);
            _allCountries[772] = new CountryTableEntry("Tokelau", "TK", "TKL", 772);
            _allCountries[776] = new CountryTableEntry("Tonga", "TO", "TON", 776);
            _allCountries[780] = new CountryTableEntry("Trinidad and Tobago", "TT", "TTO", 780);
            _allCountries[788] = new CountryTableEntry("Tunisia", "TN", "TUN", 788);
            _allCountries[792] = new CountryTableEntry("Turkey", "TR", "TUR", 792);
            _allCountries[795] = new CountryTableEntry("Turkmenistan", "TM", "TKM", 795);
            _allCountries[796] = new CountryTableEntry("Turks and Caicos Islands", "TC", "TCA", 796);
            _allCountries[798] = new CountryTableEntry("Tuvalu", "TV", "TUV", 798);
            _allCountries[800] = new CountryTableEntry("Uganda", "UG", "UGA", 800);
            _allCountries[804] = new CountryTableEntry("Ukraine", "UA", "UKR", 804);
            _allCountries[784] = new CountryTableEntry("United Arab Emirates", "AE", "ARE", 784);
            _allCountries[826] = new CountryTableEntry("United Kingdom", "GB", "GBR", 826);
            _allCountries[840] = new CountryTableEntry("United States", "US", "USA", 840);
            _allCountries[581] = new CountryTableEntry("United States Minor Outlying Islands", "UM", "UMI", 581);
            _allCountries[858] = new CountryTableEntry("Uruguay", "UY", "URY", 858);
            _allCountries[860] = new CountryTableEntry("Uzbekistan", "UZ", "UZB", 860);
            _allCountries[548] = new CountryTableEntry("Vanuatu", "VU", "VUT", 548);
            _allCountries[862] = new CountryTableEntry("Venezuela, Bolivarian Republic of", "VE", "VEN", 862);
            _allCountries[704] = new CountryTableEntry("Viet Nam", "VN", "VNM", 704);
            _allCountries[092] = new CountryTableEntry("Virgin Islands, British", "VG", "VGB", 092);
            _allCountries[850] = new CountryTableEntry("Virgin Islands, U.S.", "VI", "VIR", 850);
            _allCountries[876] = new CountryTableEntry("Wallis and Futuna", "WF", "WLF", 876);
            _allCountries[732] = new CountryTableEntry("Western Sahara", "EH", "ESH", 732);
            _allCountries[887] = new CountryTableEntry("Yemen", "YE", "YEM", 887);
            _allCountries[894] = new CountryTableEntry("Zambia", "ZM", "ZMB", 894);
            _allCountries[716] = new CountryTableEntry("Zimbabwe", "ZW", "ZWE", 716);

            AF = new Country(004);
            AX = new Country(248);
            AL = new Country(008);
            DZ = new Country(012);
            AS = new Country(016);
            AD = new Country(020);
            AO = new Country(024);
            AI = new Country(660);
            AQ = new Country(010);
            AG = new Country(028);
            AR = new Country(032);
            AM = new Country(051);
            AW = new Country(533);
            AU = new Country(036);
            AT = new Country(040);
            AZ = new Country(031);
            BS = new Country(044);
            BH = new Country(048);
            BD = new Country(050);
            BB = new Country(052);
            BY = new Country(112);
            BE = new Country(056);
            BZ = new Country(084);
            BJ = new Country(204);
            BM = new Country(060);
            BT = new Country(064);
            BO = new Country(068);
            BQ = new Country(535);
            BA = new Country(070);
            BW = new Country(072);
            BV = new Country(074);
            BR = new Country(076);
            IO = new Country(086);
            BN = new Country(096);
            BG = new Country(100);
            BF = new Country(854);
            BI = new Country(108);
            KH = new Country(116);
            CM = new Country(120);
            CA = new Country(124);
            CV = new Country(132);
            KY = new Country(136);
            CF = new Country(140);
            TD = new Country(148);
            CL = new Country(152);
            CN = new Country(156);
            CX = new Country(162);
            CC = new Country(166);
            CO = new Country(170);
            KM = new Country(174);
            CG = new Country(178);
            CD = new Country(180);
            CK = new Country(184);
            CR = new Country(188);
            CI = new Country(384);
            HR = new Country(191);
            CU = new Country(192);
            CW = new Country(531);
            CY = new Country(196);
            CZ = new Country(203);
            DK = new Country(208);
            DJ = new Country(262);
            DM = new Country(212);
            DO = new Country(214);
            EC = new Country(218);
            EG = new Country(818);
            SV = new Country(222);
            GQ = new Country(226);
            ER = new Country(232);
            EE = new Country(233);
            ET = new Country(231);
            FK = new Country(238);
            FO = new Country(234);
            FJ = new Country(242);
            FI = new Country(246);
            FR = new Country(250);
            GF = new Country(254);
            PF = new Country(258);
            TF = new Country(260);
            GA = new Country(266);
            GM = new Country(270);
            GE = new Country(268);
            DE = new Country(276);
            GH = new Country(288);
            GI = new Country(292);
            GR = new Country(300);
            GL = new Country(304);
            GD = new Country(308);
            GP = new Country(312);
            GU = new Country(316);
            GT = new Country(320);
            GG = new Country(831);
            GN = new Country(324);
            GW = new Country(624);
            GY = new Country(328);
            HT = new Country(332);
            HM = new Country(334);
            VA = new Country(336);
            HN = new Country(340);
            HK = new Country(344);
            HU = new Country(348);
            IS = new Country(352);
            IN = new Country(356);
            ID = new Country(360);
            IR = new Country(364);
            IQ = new Country(368);
            IE = new Country(372);
            IM = new Country(833);
            IL = new Country(376);
            IT = new Country(380);
            JM = new Country(388);
            JP = new Country(392);
            JE = new Country(832);
            JO = new Country(400);
            KZ = new Country(398);
            KE = new Country(404);
            KI = new Country(296);
            KP = new Country(408);
            KR = new Country(410);
            KW = new Country(414);
            KG = new Country(417);
            LA = new Country(418);
            LV = new Country(428);
            LB = new Country(422);
            LS = new Country(426);
            LR = new Country(430);
            LY = new Country(434);
            LI = new Country(438);
            LT = new Country(440);
            LU = new Country(442);
            MO = new Country(446);
            MK = new Country(807);
            MG = new Country(450);
            MW = new Country(454);
            MY = new Country(458);
            MV = new Country(462);
            ML = new Country(466);
            MT = new Country(470);
            MH = new Country(584);
            MQ = new Country(474);
            MR = new Country(478);
            MU = new Country(480);
            YT = new Country(175);
            MX = new Country(484);
            FM = new Country(583);
            MD = new Country(498);
            MC = new Country(492);
            MN = new Country(496);
            ME = new Country(499);
            MS = new Country(500);
            MA = new Country(504);
            MZ = new Country(508);
            MM = new Country(104);
            NA = new Country(516);
            NR = new Country(520);
            NP = new Country(524);
            NL = new Country(528);
            NC = new Country(540);
            NZ = new Country(554);
            NI = new Country(558);
            NE = new Country(562);
            NG = new Country(566);
            NU = new Country(570);
            NF = new Country(574);
            MP = new Country(580);
            NO = new Country(578);
            OM = new Country(512);
            PK = new Country(586);
            PW = new Country(585);
            PS = new Country(275);
            PA = new Country(591);
            PG = new Country(598);
            PY = new Country(600);
            PE = new Country(604);
            PH = new Country(608);
            PN = new Country(612);
            PL = new Country(616);
            PT = new Country(620);
            PR = new Country(630);
            QA = new Country(634);
            RE = new Country(638);
            RO = new Country(642);
            RU = new Country(643);
            RW = new Country(646);
            BL = new Country(652);
            SH = new Country(654);
            KN = new Country(659);
            LC = new Country(662);
            MF = new Country(663);
            PM = new Country(666);
            VC = new Country(670);
            WS = new Country(882);
            SM = new Country(674);
            ST = new Country(678);
            SA = new Country(682);
            SN = new Country(686);
            RS = new Country(688);
            SC = new Country(690);
            SL = new Country(694);
            SG = new Country(702);
            SX = new Country(534);
            SK = new Country(703);
            SI = new Country(705);
            SB = new Country(090);
            SO = new Country(706);
            ZA = new Country(710);
            GS = new Country(239);
            SS = new Country(728);
            ES = new Country(724);
            LK = new Country(144);
            SD = new Country(729);
            SR = new Country(740);
            SJ = new Country(744);
            SZ = new Country(748);
            SE = new Country(752);
            CH = new Country(756);
            SY = new Country(760);
            TW = new Country(158);
            TJ = new Country(762);
            TZ = new Country(834);
            TH = new Country(764);
            TL = new Country(626);
            TG = new Country(768);
            TK = new Country(772);
            TO = new Country(776);
            TT = new Country(780);
            TN = new Country(788);
            TR = new Country(792);
            TM = new Country(795);
            TC = new Country(796);
            TV = new Country(798);
            UG = new Country(800);
            UA = new Country(804);
            AE = new Country(784);
            GB = new Country(826);
            US = new Country(840);
            UM = new Country(581);
            UY = new Country(858);
            UZ = new Country(860);
            VU = new Country(548);
            VE = new Country(862);
            VN = new Country(704);
            VG = new Country(092);
            VI = new Country(850);
            WF = new Country(876);
            EH = new Country(732);
            YE = new Country(887);
            ZM = new Country(894);
            ZW = new Country(716);

            Debug.Assert(_allCountries.All(x => x.Key == x.Value._numericCode));
            Debug.Assert(_allCountries.Values.Select(x => x._name).Distinct().Count() == _allCountries.Count);
            Debug.Assert(_allCountries.Values.Select(x => x._twoLetterCode).Distinct().Count() == _allCountries.Count);
            Debug.Assert(_allCountries.Values.Select(x => x._threeLetterCode).Distinct().Count() == _allCountries.Count);
            Debug.Assert(_allCountries.Values.Select(x => x._numericCode).Distinct().Count() == _allCountries.Count);
        }

        #region Static Country Fields

        public static readonly Country AF;
        public static readonly Country AX;
        public static readonly Country AL;
        public static readonly Country DZ;
        public static readonly Country AS;
        public static readonly Country AD;
        public static readonly Country AO;
        public static readonly Country AI;
        public static readonly Country AQ;
        public static readonly Country AG;
        public static readonly Country AR;
        public static readonly Country AM;
        public static readonly Country AW;
        public static readonly Country AU;
        public static readonly Country AT;
        public static readonly Country AZ;
        public static readonly Country BS;
        public static readonly Country BH;
        public static readonly Country BD;
        public static readonly Country BB;
        public static readonly Country BY;
        public static readonly Country BE;
        public static readonly Country BZ;
        public static readonly Country BJ;
        public static readonly Country BM;
        public static readonly Country BT;
        public static readonly Country BO;
        public static readonly Country BQ;
        public static readonly Country BA;
        public static readonly Country BW;
        public static readonly Country BV;
        public static readonly Country BR;
        public static readonly Country IO;
        public static readonly Country BN;
        public static readonly Country BG;
        public static readonly Country BF;
        public static readonly Country BI;
        public static readonly Country KH;
        public static readonly Country CM;
        public static readonly Country CA;
        public static readonly Country CV;
        public static readonly Country KY;
        public static readonly Country CF;
        public static readonly Country TD;
        public static readonly Country CL;
        public static readonly Country CN;
        public static readonly Country CX;
        public static readonly Country CC;
        public static readonly Country CO;
        public static readonly Country KM;
        public static readonly Country CG;
        public static readonly Country CD;
        public static readonly Country CK;
        public static readonly Country CR;
        public static readonly Country CI;
        public static readonly Country HR;
        public static readonly Country CU;
        public static readonly Country CW;
        public static readonly Country CY;
        public static readonly Country CZ;
        public static readonly Country DK;
        public static readonly Country DJ;
        public static readonly Country DM;
        public static readonly Country DO;
        public static readonly Country EC;
        public static readonly Country EG;
        public static readonly Country SV;
        public static readonly Country GQ;
        public static readonly Country ER;
        public static readonly Country EE;
        public static readonly Country ET;
        public static readonly Country FK;
        public static readonly Country FO;
        public static readonly Country FJ;
        public static readonly Country FI;
        public static readonly Country FR;
        public static readonly Country GF;
        public static readonly Country PF;
        public static readonly Country TF;
        public static readonly Country GA;
        public static readonly Country GM;
        public static readonly Country GE;
        public static readonly Country DE;
        public static readonly Country GH;
        public static readonly Country GI;
        public static readonly Country GR;
        public static readonly Country GL;
        public static readonly Country GD;
        public static readonly Country GP;
        public static readonly Country GU;
        public static readonly Country GT;
        public static readonly Country GG;
        public static readonly Country GN;
        public static readonly Country GW;
        public static readonly Country GY;
        public static readonly Country HT;
        public static readonly Country HM;
        public static readonly Country VA;
        public static readonly Country HN;
        public static readonly Country HK;
        public static readonly Country HU;
        public static readonly Country IS;
        public static readonly Country IN;
        public static readonly Country ID;
        public static readonly Country IR;
        public static readonly Country IQ;
        public static readonly Country IE;
        public static readonly Country IM;
        public static readonly Country IL;
        public static readonly Country IT;
        public static readonly Country JM;
        public static readonly Country JP;
        public static readonly Country JE;
        public static readonly Country JO;
        public static readonly Country KZ;
        public static readonly Country KE;
        public static readonly Country KI;
        public static readonly Country KP;
        public static readonly Country KR;
        public static readonly Country KW;
        public static readonly Country KG;
        public static readonly Country LA;
        public static readonly Country LV;
        public static readonly Country LB;
        public static readonly Country LS;
        public static readonly Country LR;
        public static readonly Country LY;
        public static readonly Country LI;
        public static readonly Country LT;
        public static readonly Country LU;
        public static readonly Country MO;
        public static readonly Country MK;
        public static readonly Country MG;
        public static readonly Country MW;
        public static readonly Country MY;
        public static readonly Country MV;
        public static readonly Country ML;
        public static readonly Country MT;
        public static readonly Country MH;
        public static readonly Country MQ;
        public static readonly Country MR;
        public static readonly Country MU;
        public static readonly Country YT;
        public static readonly Country MX;
        public static readonly Country FM;
        public static readonly Country MD;
        public static readonly Country MC;
        public static readonly Country MN;
        public static readonly Country ME;
        public static readonly Country MS;
        public static readonly Country MA;
        public static readonly Country MZ;
        public static readonly Country MM;
        public static readonly Country NA;
        public static readonly Country NR;
        public static readonly Country NP;
        public static readonly Country NL;
        public static readonly Country NC;
        public static readonly Country NZ;
        public static readonly Country NI;
        public static readonly Country NE;
        public static readonly Country NG;
        public static readonly Country NU;
        public static readonly Country NF;
        public static readonly Country MP;
        public static readonly Country NO;
        public static readonly Country OM;
        public static readonly Country PK;
        public static readonly Country PW;
        public static readonly Country PS;
        public static readonly Country PA;
        public static readonly Country PG;
        public static readonly Country PY;
        public static readonly Country PE;
        public static readonly Country PH;
        public static readonly Country PN;
        public static readonly Country PL;
        public static readonly Country PT;
        public static readonly Country PR;
        public static readonly Country QA;
        public static readonly Country RE;
        public static readonly Country RO;
        public static readonly Country RU;
        public static readonly Country RW;
        public static readonly Country BL;
        public static readonly Country SH;
        public static readonly Country KN;
        public static readonly Country LC;
        public static readonly Country MF;
        public static readonly Country PM;
        public static readonly Country VC;
        public static readonly Country WS;
        public static readonly Country SM;
        public static readonly Country ST;
        public static readonly Country SA;
        public static readonly Country SN;
        public static readonly Country RS;
        public static readonly Country SC;
        public static readonly Country SL;
        public static readonly Country SG;
        public static readonly Country SX;
        public static readonly Country SK;
        public static readonly Country SI;
        public static readonly Country SB;
        public static readonly Country SO;
        public static readonly Country ZA;
        public static readonly Country GS;
        public static readonly Country SS;
        public static readonly Country ES;
        public static readonly Country LK;
        public static readonly Country SD;
        public static readonly Country SR;
        public static readonly Country SJ;
        public static readonly Country SZ;
        public static readonly Country SE;
        public static readonly Country CH;
        public static readonly Country SY;
        public static readonly Country TW;
        public static readonly Country TJ;
        public static readonly Country TZ;
        public static readonly Country TH;
        public static readonly Country TL;
        public static readonly Country TG;
        public static readonly Country TK;
        public static readonly Country TO;
        public static readonly Country TT;
        public static readonly Country TN;
        public static readonly Country TR;
        public static readonly Country TM;
        public static readonly Country TC;
        public static readonly Country TV;
        public static readonly Country UG;
        public static readonly Country UA;
        public static readonly Country AE;
        public static readonly Country GB;
        public static readonly Country US;
        public static readonly Country UM;
        public static readonly Country UY;
        public static readonly Country UZ;
        public static readonly Country VU;
        public static readonly Country VE;
        public static readonly Country VN;
        public static readonly Country VG;
        public static readonly Country VI;
        public static readonly Country WF;
        public static readonly Country EH;
        public static readonly Country YE;
        public static readonly Country ZM;
        public static readonly Country ZW;
        #endregion

        public Country(string countryCode) : this(FindId(countryCode)) { }

        public Country(int numericCode)
        {
            if (_allCountries.ContainsKey(numericCode) == false)
                throw new ArgumentException($"The value isn't a valid ISO 3166 numeric code. {numericCode}", nameof(numericCode));

            _countryNumericCode = numericCode;
        }

        /// <summary>
        /// ISO 3166-1 numeric – three-digit country codes which are identical to those developed and maintained by the United Nations Statistics Division, with the advantage of script (writing system) independence, and hence useful for people or systems using non-Latin scripts.
        /// </summary>
        public readonly int NumericCode => _countryNumericCode;

        /// <summary>
        /// Country name
        /// </summary>
        public readonly string Name => GetEntry(_countryNumericCode)._name;

        /// <summary>
        /// ISO 3166-1 alpha-2 – two-letter country codes which are also used to create the ISO 3166-2 country subdivision codes and the Internet country code top-level domains.
        /// </summary>
        public readonly string TwoLetterCode => GetEntry(_countryNumericCode)._twoLetterCode;

        /// <summary>
        /// ISO 3166-1 alpha-3 – three-letter country codes which may allow a better visual association between the codes and the country names than the 3166-1 alpha-2 codes.
        /// </summary>
        public readonly string ThreeLetterCode => GetEntry(_countryNumericCode)._threeLetterCode;

        public readonly ReadOnlyCollection<Subdivision> Subdivisions => Subdivision.GetCountrySubdivisions(this);

        private static int FindId(string countryCode)
        {
            foreach (var country in _allCountries) // replacing Linq with foreach massively reduces allocations and improves object initialization time
            {
                if (country.Value._twoLetterCode.Equals(countryCode) || country.Value._threeLetterCode.Equals(countryCode))
                {
                    return country.Value._numericCode; // no need to continue because the check for uniqueness was done in the static constructor
                }
            }

            throw new ArgumentException($"Invalid country code {countryCode}", nameof(countryCode));
        }

        private static CountryTableEntry GetEntry(int countryNumericCode)
        {
            if (_allCountries.TryGetValue(countryNumericCode, out CountryTableEntry entry) == false)
                throw new ArgumentException($"Unknown country: {countryNumericCode}");
            return entry;
        }

        public static IEnumerable<Country> GetAllCountries() => _allCountries.Keys.Select(x => new Country(x));

        public static bool operator ==(Country left, Country right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Country left, Country right)
        {
            return left.Equals(right) == false;
        }

        public override readonly bool Equals(object obj)
        {
            if (obj is Country other)
                return Equals(other);

            return false;
        }

        public readonly bool Equals(Country other)
        {
            return _countryNumericCode == other._countryNumericCode;
        }

        public override readonly int GetHashCode()
        {
            unchecked
            {
                return _countryNumericCode.GetHashCode() ^ 7883;
            }
        }

        public override readonly string ToString() => TwoLetterCode;

        private readonly struct CountryTableEntry
        {
            internal readonly string _name;
            internal readonly string _twoLetterCode;
            internal readonly string _threeLetterCode;
            internal readonly int _numericCode;

            internal CountryTableEntry(string name, string twoLetterCode, string threeLetterCode, int numericCode)
            {
                _name = name;
                _twoLetterCode = twoLetterCode;
                _threeLetterCode = threeLetterCode;
                _numericCode = numericCode;
            }
        }
    }
}
