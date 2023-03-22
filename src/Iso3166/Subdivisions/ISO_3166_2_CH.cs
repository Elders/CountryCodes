using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:CH is the entry for Switzerland in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO),
        /// which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// The abbreviation is derived from Latin name for Switzerland, Confoederatio Helvetica("Helvetic Confederation").
        /// Currently for Switzerland, ISO 3166-2 codes are defined for 26 cantons.
        /// Each code consists of two parts, separated by a hyphen.The first part is CH, the ISO 3166-1 alpha-2 code of Switzerland.
        /// The second part is two letters, currently used in vehicle registration plates.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:CH
        /// LastUpdated: 2023-03-20
        /// </remarks>
        internal static void ISO_3166_2_CH()
        {
            Add(Country.CH, "AG", "Aargau");
            Add(Country.CH, "AR", "Appenzell Ausserrhoden");
            Add(Country.CH, "AI", "Appenzell Innerrhoden");
            Add(Country.CH, "BL", "Basel-Landschaft");
            Add(Country.CH, "BS", "Basel-Stadt");
            Add(Country.CH, "BE", "Bern");
            Add(Country.CH, "FR", "Fribourg");
            Add(Country.CH, "GE", "Genève");
            Add(Country.CH, "GL", "Glarus");
            Add(Country.CH, "GR", "Graubünden");
            Add(Country.CH, "JU", "Jura");
            Add(Country.CH, "LU", "Luzern");
            Add(Country.CH, "NE", "Neuchâtel");
            Add(Country.CH, "NW", "Nidwalden");
            Add(Country.CH, "OW", "Obwalden");
            Add(Country.CH, "SG", "Sankt Gallen");
            Add(Country.CH, "SH", "Schaffhausen");
            Add(Country.CH, "SZ", "Schwyz");
            Add(Country.CH, "SO", "Solothurn");
            Add(Country.CH, "TG", "Thurgau");
            Add(Country.CH, "TI", "Ticino");
            Add(Country.CH, "UR", "Uri");
            Add(Country.CH, "VS", "Valais");
            Add(Country.CH, "VD", "Vaud");
            Add(Country.CH, "ZG", "Zug");
            Add(Country.CH, "ZH", "Zürich");

            Debug.Assert(_subdivisionsPerCountry[Country.CH].Count == 26, "Number of subdivisions is wrong.");
        }
    }
}
