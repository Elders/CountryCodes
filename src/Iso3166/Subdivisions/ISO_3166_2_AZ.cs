using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:AZ is the entry for Azerbaijan in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization (ISO),
        /// which defines codes for the names of the principal subdivisions (e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Azerbaijan, ISO 3166-2 codes are defined for two levels of subdivisions:
        ///     1 autonomous republic(i.e., Nakhchivan Autonomous Republic)
        ///     11 municipalities and 66 rayons
        /// The eleven municipalities have special status equal to the rayons.Şuşa, the disputed municipality, has been removed from the list.
        /// Each code consists of two parts, separated by a hyphen. The first part is AZ, the ISO 3166-1 alpha-2 code of Azerbaijan.The second part is either of the following:
        ///     two letters: autonomous republic and municipalities
        ///     three letters: rayons
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:AZ
        /// LastUpdated: 2023-03-22
        /// </remarks>
        internal static void ISO_3166_2_AZ()
        {
            Add(Country.AZ, "BA", "Baku");
            Add(Country.AZ, "GA", "Ganja");
            Add(Country.AZ, "LA", "Lankaran");
            Add(Country.AZ, "MI", "Mingachevir");
            Add(Country.AZ, "NA", "Naftalan");
            Add(Country.AZ, "NV", "Nakhchivan");
            Add(Country.AZ, "SA", "Shaki");
            Add(Country.AZ, "SR", "Shirvan");
            Add(Country.AZ, "SM", "Sumqayıt");
            Add(Country.AZ, "XA", "Stepanakert");
            Add(Country.AZ, "YE", "Yevlakh");
            Add(Country.AZ, "ABS", "Absheron");
            Add(Country.AZ, "AGC", "Aghjabadi");
            Add(Country.AZ, "AGM", "Agdam");
            Add(Country.AZ, "AGS", "Agdash");
            Add(Country.AZ, "AGA", "Agstafa");
            Add(Country.AZ, "AGU", "Agsu");
            Add(Country.AZ, "AST", "Astara");
            Add(Country.AZ, "BAB", "Babek");
            Add(Country.AZ, "BAL", "Balakan");
            Add(Country.AZ, "BAR", "Barda");
            Add(Country.AZ, "BEY", "Beylagan");
            Add(Country.AZ, "BIL", "Bilasuvar");
            Add(Country.AZ, "CAB", "Jabrayil");
            Add(Country.AZ, "CAL", "Jalilabad");
            Add(Country.AZ, "CUL", "Julfa");
            Add(Country.AZ, "DAS", "Dashkasan");
            Add(Country.AZ, "FUZ", "Fuzuli");
            Add(Country.AZ, "GAD", "Gadabay");
            Add(Country.AZ, "GOR", "Goranboy");
            Add(Country.AZ, "GOY", "Goychay");
            Add(Country.AZ, "GYG", "Goygol");
            Add(Country.AZ, "HAC", "Hajigabul");
            Add(Country.AZ, "IMI", "Imishli");
            Add(Country.AZ, "ISM", "Ismailli");
            Add(Country.AZ, "KAL", "Kalbajar");
            Add(Country.AZ, "KAN", "Kangarli");
            Add(Country.AZ, "KUR", "Kurdamir");
            Add(Country.AZ, "LAC", "Lachin");
            Add(Country.AZ, "LAN", "Lankaran");
            Add(Country.AZ, "LER", "Lerik");
            Add(Country.AZ, "MAS", "Masally");
            Add(Country.AZ, "NEF", "Neftchala");
            Add(Country.AZ, "OGU", "Oghuz");
            Add(Country.AZ, "ORD", "Ordubad");
            Add(Country.AZ, "QAX", "Qakh");
            Add(Country.AZ, "QAZ", "Qazakh");
            Add(Country.AZ, "QAB", "Qbala");
            Add(Country.AZ, "QOB", "Gobustan");
            Add(Country.AZ, "QBA", "Quba");
            Add(Country.AZ, "QBI", "Qubadlı");
            Add(Country.AZ, "QUS", "Qusar");
            Add(Country.AZ, "SAT", "Saatly");
            Add(Country.AZ, "SAB", "Sabirabad");
            Add(Country.AZ, "SBN", "Shabran");
            Add(Country.AZ, "SAH", "Shahbuz");
            Add(Country.AZ, "SAL", "Salyan");
            Add(Country.AZ, "SMI", "Shamakhi");
            Add(Country.AZ, "SMX", "Samukh");
            Add(Country.AZ, "SAD", "Sadarak");
            Add(Country.AZ, "SAK", "Shaki");
            Add(Country.AZ, "SKR", "Shamkir");
            Add(Country.AZ, "SAR", "Sharur");
            Add(Country.AZ, "SIY", "Siazan");
            Add(Country.AZ, "SUS", "Shusha");
            Add(Country.AZ, "TAR", "Tartar");
            Add(Country.AZ, "TOV", "Tovuz");
            Add(Country.AZ, "UCA", "Ujar");
            Add(Country.AZ, "XAC", "Khachmaz");
            Add(Country.AZ, "XIZ", "Khizi");
            Add(Country.AZ, "XCI", "Khojaly");
            Add(Country.AZ, "XVD", "Khojavend");
            Add(Country.AZ, "YAR", "Yardymli");
            Add(Country.AZ, "YEV", "Yevlakh");
            Add(Country.AZ, "ZAQ", "Zaqatala");
            Add(Country.AZ, "ZAN", "Zangilan");
            Add(Country.AZ, "ZAR", "Zardab");

            Debug.Assert(_subdivisionsPerCountry[Country.AZ].Count == 77, $"{Country.AZ} Number of subdivisions is wrong.");
        }
    }
}
