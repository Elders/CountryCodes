using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:SC is the entry for Seychelles in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO),
        /// which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Seychelles, ISO 3166-2 codes are defined for 27 districts.The Outer Islands, which are not part of any district, are not listed.
        /// Each code consists of two parts, separated by a hyphen.The first part is SC, the ISO 3166-1 alpha-2 code of Seychelles.The second part is two digits:
        ///         01–23: districts created in 1979
        ///         24–25: districts created in 1998
        ///         26–27: districts created in 2020
        /// he codes for each group of districts are assigned in French alphabetical order, except Au Cap, whose code is assigned based on its former name, Anse Louis.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:SC
        /// LastUpdated: 2023-03-21
        /// </remarks>
        internal static void ISO_3166_2_SC()
        {
            Add(Country.SC, "01", "Anse aux Pins");
            Add(Country.SC, "02", "Anse Boileau");
            Add(Country.SC, "03", "Anse Etoile");
            Add(Country.SC, "05", "Anse Royale");
            Add(Country.SC, "04", "Au Cap");
            Add(Country.SC, "06", "Baie Lazare");
            Add(Country.SC, "07", "Baie Sainte Anne");
            Add(Country.SC, "08", "Beau Vallon");
            Add(Country.SC, "09", "Bel Air");
            Add(Country.SC, "10", "Bel Ombre");
            Add(Country.SC, "11", "Cascade");
            Add(Country.SC, "16", "English River");
            Add(Country.SC, "12", "Glacis");
            Add(Country.SC, "13", "Grand Anse Mahe");
            Add(Country.SC, "14", "Grand Anse Praslin");
            Add(Country.SC, "26", "Ile Perseverance I");
            Add(Country.SC, "27", "Ile Perseverance II");
            Add(Country.SC, "15", "La Digue");
            Add(Country.SC, "24", "Les Mamelles");
            Add(Country.SC, "17", "Mont Buxton");
            Add(Country.SC, "18", "Mont Fleuri");
            Add(Country.SC, "19", "Plaisance");
            Add(Country.SC, "20", "Pointe Larue");
            Add(Country.SC, "21", "Port Glaud");
            Add(Country.SC, "25", "Roche Caiman");
            Add(Country.SC, "22", "Saint Louis");
            Add(Country.SC, "23", "Takamaka");

            Debug.Assert(_subdivisionsPerCountry[Country.SC].Count == 27, $"{Country.SC} Number of subdivisions is wrong.");
        }
    }
}
