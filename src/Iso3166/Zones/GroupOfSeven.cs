namespace Elders.Iso3166
{
    public partial struct EconomicZone
    {
        /// <summary>
        /// The Group of Seven is a forum of advanced economies rather than a trade arrangement. The European Union takes part but is not a member state and so is not listed here.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/G7
        /// LastUpdated: 2026-08-15
        /// </remarks>
        internal static void GroupOfSeven()
        {
            Add("G7", "Group of Seven", EconomicZoneType.GlobalEconomicGroup,
                Country.CA, Country.FR, Country.DE, Country.IT, Country.JP, Country.GB, Country.US);
        }
    }
}
