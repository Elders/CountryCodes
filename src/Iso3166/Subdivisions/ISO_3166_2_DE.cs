using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:DE is the entry for Germany in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization (ISO),
        /// which defines codes for the names of the principal subdivisions (e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// The current version of the standard defines codes for all 16 German states, referring to them using the German words Land(singular) and Länder(plural).
        /// Each code consists of two parts, separated by a hyphen.The first part is DE, the ISO 3166-1 alpha-2 code for Germany; the second part is two letters derived from the name of the Land.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:DE
        /// LastUpdated: 2023-03-23
        /// </remarks>
        internal static void ISO_3166_2_DE()
        {
            Add(Country.DE, "BW", "Baden-Württemberg");
            Add(Country.DE, "BY", "Bavaria");
            Add(Country.DE, "BE", "Berlin");
            Add(Country.DE, "BB", "Brandenburg");
            Add(Country.DE, "HB", "Bremen");
            Add(Country.DE, "HH", "Hamburg");
            Add(Country.DE, "HE", "Hesse");
            Add(Country.DE, "MV", "Mecklenburg-Western Pomerania");
            Add(Country.DE, "NI", "Lower Saxony");
            Add(Country.DE, "NW", "North Rhine-Westphalia");
            Add(Country.DE, "RP", "Rhineland-Palatinate");
            Add(Country.DE, "SL", "Saarland");
            Add(Country.DE, "SN", "Saxony");
            Add(Country.DE, "ST", "Saxony-Anhalt");
            Add(Country.DE, "SH", "Schleswig-Holstein");
            Add(Country.DE, "TH", "Thuringia");

            Debug.Assert(_subdivisionsPerCountry[Country.DE].Count == 16, "Number of subdivisions is wrong.");
        }
    }
}
