using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:TF is the entry for the French Southern Territories (French Southern and Antarctic Lands) in ISO 3166-2,
        /// a part of the ISO 3166 standard which defines codes for the principal subdivisions of all countries included in ISO 3166-1. Currently, the entry does not include any codes.
        /// The French Southern and Antarctic Lands is an overseas territorial collectivity of France and are officially assigned the ISO 3166-1 alpha-2 code TF.
        /// As an internal territory, it is also assigned the ISO 3166-2 code FR-TF under the entry for France.
        /// Under the definition in ISO 3166-1, the French Southern and Antarctic Lands excludes Adélie Land, which is covered by Antarctica, with alpha-2 code AQ.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:TF
        /// LastUpdated: 2023-03-26
        /// </remarks>
        internal static void ISO_3166_2_TF()
        {
            Debug.Assert(_subdivisionsPerCountry.ContainsKey(Country.TF) == false, $"{Country.TF} Number of subdivisions is wrong.");
        }
    }
}
