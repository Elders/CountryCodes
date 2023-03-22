using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:IT is the entry for Italy in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO),
        /// which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Italy, ISO 3166-2 codes are defined for two levels of subdivisions:
        ///     15 regions and 5 autonomous regions
        ///     80 provinces, 2 autonomous provinces, 4 decentralized regional entities, 6 free municipal consortia and 14 metropolitan cities
        /// Each code consists of two parts, separated by a hyphen.The first part is IT, the ISO 3166-1 alpha-2 code of Italy.The second part is either of the following:
        ///     two digits: regions
        ///     two letters: provinces, decentralized regional entities, free municipal consortia and metropolitan cities
        /// For the regions, the first digit indicates the geographical region where the subdivision is in:
        ///     2, 3, 4: Northern Italy
        ///     5: Central Italy(excluding Lazio)
        ///     6, 7: Southern Italy(including Lazio)
        ///     8: Insular Italy
        /// For provinces, the two-letter part is an abbreviation of the province name, such as 'PG' for Perugia, although, as an exception, the code for former Medio
        /// Campidano(IT-VS) whose name was based on its two capitals, Villacidro and Sanluri.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:IT
        /// LastUpdated: 2023-03-16
        /// </remarks>
        internal static void ISO_3166_2_IT()
        {
            Add(Country.IT, "65", "Abruzzo");
            Add(Country.IT, "77", "Basilicata");
            Add(Country.IT, "78", "Calabria");
            Add(Country.IT, "72", "Campania");
            Add(Country.IT, "45", "Emilia-Romagna");
            Add(Country.IT, "62", "Lazio");
            Add(Country.IT, "42", "Liguria");
            Add(Country.IT, "25", "Lombardy");
            Add(Country.IT, "57", "Marche");
            Add(Country.IT, "67", "Molise");
            Add(Country.IT, "21", "Piedmont");
            Add(Country.IT, "75", "Apulia");
            Add(Country.IT, "52", "Tuscany");
            Add(Country.IT, "55", "Umbria");
            Add(Country.IT, "34", "Veneto");
            Add(Country.IT, "36", "Friuli Venezia Giulia");
            Add(Country.IT, "88", "Sardinia");
            Add(Country.IT, "82", "Sicily");
            Add(Country.IT, "32", "Trentino-South Tyrol");
            Add(Country.IT, "23", "Aosta Valley");
            Add(Country.IT, "AL", "Alessandria");
            Add(Country.IT, "AN", "Ancona");
            Add(Country.IT, "AR", "Arezzo");
            Add(Country.IT, "AP", "Ascoli Piceno");
            Add(Country.IT, "AT", "Asti");
            Add(Country.IT, "AV", "Avellino");
            Add(Country.IT, "BT", "Barletta-Andria-Trani");
            Add(Country.IT, "BL", "Belluno");
            Add(Country.IT, "BN", "Benevento");
            Add(Country.IT, "BG", "Bergamo");
            Add(Country.IT, "BI", "Biella");
            Add(Country.IT, "BS", "Brescia");
            Add(Country.IT, "BR", "Brindisi");
            Add(Country.IT, "CB", "Campobasso");
            Add(Country.IT, "CE", "Caserta");
            Add(Country.IT, "CZ", "Catanzaro");
            Add(Country.IT, "CH", "Chieti");
            Add(Country.IT, "CO", "Como");
            Add(Country.IT, "CS", "Cosenza");
            Add(Country.IT, "CR", "Cremona");
            Add(Country.IT, "KR", "Crotone");
            Add(Country.IT, "CN", "Cuneo");
            Add(Country.IT, "FM", "Fermo");
            Add(Country.IT, "FE", "Ferrara");
            Add(Country.IT, "FG", "Foggia");
            Add(Country.IT, "FC", "Forlì-Cesena");
            Add(Country.IT, "FR", "Frosinone");
            Add(Country.IT, "GR", "Grosseto");
            Add(Country.IT, "IM", "Imperia");
            Add(Country.IT, "IS", "Isernia");
            Add(Country.IT, "SP", "La Spezia");
            Add(Country.IT, "AQ", "L'Aquila");
            Add(Country.IT, "LT", "Latina");
            Add(Country.IT, "LE", "Lecce");
            Add(Country.IT, "LC", "Lecco");
            Add(Country.IT, "LI", "Livorno");
            Add(Country.IT, "LO", "Lodi");
            Add(Country.IT, "LU", "Lucca");
            Add(Country.IT, "MC", "Macerata");
            Add(Country.IT, "MN", "Mantova");
            Add(Country.IT, "MS", "Massa-Carrara");
            Add(Country.IT, "MT", "Matera");
            Add(Country.IT, "MO", "Modena");
            Add(Country.IT, "MB", "Monza e Brianza");
            Add(Country.IT, "NO", "Novara");
            Add(Country.IT, "NU", "Nuoro");
            Add(Country.IT, "OR", "Oristano");
            Add(Country.IT, "PD", "Padova");
            Add(Country.IT, "PR", "Parma");
            Add(Country.IT, "PV", "Pavia");
            Add(Country.IT, "PG", "Perugia");
            Add(Country.IT, "PU", "Pesaro e Urbino");
            Add(Country.IT, "PE", "Pescara");
            Add(Country.IT, "PC", "Piacenza");
            Add(Country.IT, "PI", "Pisa");
            Add(Country.IT, "PT", "Pistoia");
            Add(Country.IT, "PZ", "Potenza");
            Add(Country.IT, "PO", "Prato");
            Add(Country.IT, "RA", "Ravenna");
            Add(Country.IT, "RE", "Reggio Emilia");
            Add(Country.IT, "RI", "Rieti");
            Add(Country.IT, "RN", "Rimini");
            Add(Country.IT, "RO", "Rovigo");
            Add(Country.IT, "SA", "Salerno");
            Add(Country.IT, "SS", "Sassari");
            Add(Country.IT, "SV", "Savona");
            Add(Country.IT, "SI", "Siena");
            Add(Country.IT, "SO", "Sondrio");
            Add(Country.IT, "SU", "Sud Sardegna");
            Add(Country.IT, "TA", "Taranto");
            Add(Country.IT, "TE", "Teramo");
            Add(Country.IT, "TR", "Terni");
            Add(Country.IT, "TV", "Treviso");
            Add(Country.IT, "VA", "Varese");
            Add(Country.IT, "VB", "Verbano-Cusio-Ossola");
            Add(Country.IT, "VC", "Vercelli");
            Add(Country.IT, "VR", "Verona");
            Add(Country.IT, "VV", "Vibo Valentia");
            Add(Country.IT, "VI", "Vicenza");
            Add(Country.IT, "VT", "Viterbo");
            Add(Country.IT, "BZ", "Bolzano, Bozen");
            Add(Country.IT, "TN", "Trento");
            Add(Country.IT, "GO", "Gorizia");
            Add(Country.IT, "PN", "Pordenone");
            Add(Country.IT, "TS", "Trieste");
            Add(Country.IT, "UD", "Udine");
            Add(Country.IT, "AG", "Agrigento");
            Add(Country.IT, "CL", "Caltanissetta");
            Add(Country.IT, "EN", "Enna");
            Add(Country.IT, "RG", "Ragusa");
            Add(Country.IT, "SR", "Siracusa");
            Add(Country.IT, "TP", "Trapani");
            Add(Country.IT, "BA", "Bari");
            Add(Country.IT, "BO", "Bologna");
            Add(Country.IT, "CA", "Cagliari");
            Add(Country.IT, "CT", "Catania");
            Add(Country.IT, "FI", "Firenze");
            Add(Country.IT, "GE", "Genova");
            Add(Country.IT, "ME", "Messina");
            Add(Country.IT, "MI", "Milano");
            Add(Country.IT, "NA", "Napoli");
            Add(Country.IT, "PA", "Palermo");
            Add(Country.IT, "RC", "Reggio Calabria");
            Add(Country.IT, "RM", "Roma");
            Add(Country.IT, "TO", "Torino");
            Add(Country.IT, "VE", "Venezia");

            Debug.Assert(_subdivisionsPerCountry[Country.IT].Count == 126, "Number of subdivisions is wrong.");
        }
    }
}
