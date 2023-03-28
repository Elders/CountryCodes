using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:GR is the entry for Greece in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization (ISO),
        /// which defines codes for the names of the principal subdivisions (e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Greece, ISO 3166-2 codes are defined for two categories of subdivisions:
        ///     13 administrative regions
        ///     1 self-governed part
        /// The departments(also called prefectures) were abolished in 2011, and were replaced approximately by regional units.The regional units were deleted from the entry in 2016.
        /// Each code consists of two parts, separated by a hyphen. The first part is GR, the ISO 3166-1 alpha-2 code of Greece.The second part is either of the following:
        ///     one letter (A–M): administrative regions
        ///     two digits: self-governed part
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:GR
        /// LastUpdated: 2023-03-23
        /// </remarks>
        internal static void ISO_3166_2_GR()
        {
            Add(Country.GR, "A", "Eastern Macedonia and Thrace");
            Add(Country.GR, "I", "Attica");
            Add(Country.GR, "G", "Western Greece");
            Add(Country.GR, "C", "Western Macedonia");
            Add(Country.GR, "F", "Ionian Islands");
            Add(Country.GR, "D", "Epirus");
            Add(Country.GR, "B", "Central Macedonia");
            Add(Country.GR, "M", "Crete");
            Add(Country.GR, "L", "Southern Aegean");
            Add(Country.GR, "J", "Peloponnese");
            Add(Country.GR, "H", "Central Greece");
            Add(Country.GR, "E", "Thessaly");
            Add(Country.GR, "K", "Northern Aegean");

            Debug.Assert(_subdivisionsPerCountry[Country.GR].Count == 13, $"{Country.YT} Number of subdivisions is wrong.");
        }
    }
}
