using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:GN is the entry for Guinea in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO),
        /// which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Guinea, ISO 3166-2 codes are defined for two levels of subdivisions:
        ///     7 administrative regions and 1 governorate
        ///     33 prefectures
        /// The governorate Conakry is the capital of the country and has special status equal to the administrative regions.
        /// Each code consists of two parts, separated by a hyphen. The first part is GN, the ISO 3166-1 alpha-2 code of Guinea.The second part is either of the following:
        ///     one letter: administrative regions and governorate
        ///     two letters: prefectures
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:GN
        /// LastUpdated: 2023-03-23
        /// </remarks>
        internal static void ISO_3166_2_GN()
        {
            Add(Country.GN, "B", "Boké");
            Add(Country.GN, "F", "Faranah");
            Add(Country.GN, "K", "Kankan");
            Add(Country.GN, "D", "Kindia");
            Add(Country.GN, "L", "Labé");
            Add(Country.GN, "M", "Mamou");
            Add(Country.GN, "N", "Nzérékoré");
            Add(Country.GN, "C", "Conakry");
            Add(Country.GN, "BE", "Beyla");
            Add(Country.GN, "BF", "Boffa");
            Add(Country.GN, "BK", "Boké");
            Add(Country.GN, "CO", "Coyah");
            Add(Country.GN, "DB", "Dabola");
            Add(Country.GN, "DL", "Dalaba");
            Add(Country.GN, "DI", "Dinguiraye");
            Add(Country.GN, "DU", "Dubréka");
            Add(Country.GN, "FA", "Faranah");
            Add(Country.GN, "FO", "Forécariah");
            Add(Country.GN, "FR", "Fria");
            Add(Country.GN, "GA", "Gaoual");
            Add(Country.GN, "GU", "Guékédou");
            Add(Country.GN, "KA", "Kankan");
            Add(Country.GN, "KE", "Kérouané");
            Add(Country.GN, "KD", "Kindia");
            Add(Country.GN, "KS", "Kissidougou");
            Add(Country.GN, "KB", "Koubia");
            Add(Country.GN, "KN", "Koundara");
            Add(Country.GN, "KO", "Kouroussa");
            Add(Country.GN, "LA", "Labé");
            Add(Country.GN, "LE", "Lélouma");
            Add(Country.GN, "LO", "Lola");
            Add(Country.GN, "MC", "Macenta");
            Add(Country.GN, "ML", "Mali");
            Add(Country.GN, "MM", "Mamou");
            Add(Country.GN, "MD", "Mandiana");
            Add(Country.GN, "NZ", "Nzérékoré");
            Add(Country.GN, "PI", "Pita");
            Add(Country.GN, "SI", "Siguiri");
            Add(Country.GN, "TE", "Télimélé");
            Add(Country.GN, "TO", "Tougué");
            Add(Country.GN, "YO", "Yomou");

            Debug.Assert(_subdivisionsPerCountry[Country.GN].Count == 41, $"{Country.GN} Number of subdivisions is wrong.");
        }
    }
}
