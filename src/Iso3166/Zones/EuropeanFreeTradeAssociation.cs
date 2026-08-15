namespace Elders.Iso3166
{
    public partial struct EconomicZone
    {
        /// <summary>
        /// The European Free Trade Association is an alternative to European Union membership, not a subset of it. None of its four members belong to the European Union.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/European_Free_Trade_Association
        /// LastUpdated: 2026-08-15
        /// </remarks>
        internal static void EuropeanFreeTradeAssociation()
        {
            Add("EFTA", "European Free Trade Association", EconomicZoneType.FreeTradeArea,
                Country.IS, Country.LI, Country.NO, Country.CH);
        }
    }
}
