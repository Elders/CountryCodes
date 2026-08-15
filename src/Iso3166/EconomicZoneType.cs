namespace Elders.Iso3166
{
    /// <summary>
    ///     What kind of arrangement an <see cref="EconomicZone"/> is.
    /// </summary>
    public enum EconomicZoneType
    {
        /// <summary>Deep integration of economic policy, e.g. the European Union.</summary>
        EconomicUnion = 0,

        /// <summary>A common external tariff, e.g. the Gulf Cooperation Council.</summary>
        CustomsUnion = 1,

        /// <summary>Free movement of goods, services, capital and people, e.g. the European Economic Area.</summary>
        SingleMarket = 2,

        /// <summary>Tariffs removed between members, e.g. EFTA or the USMCA.</summary>
        FreeTradeArea = 3,

        /// <summary>A shared currency, e.g. the euro area.</summary>
        MonetaryUnion = 4,

        /// <summary>Passport-free movement of people, e.g. the Schengen Area.</summary>
        FreeMovementArea = 5,

        /// <summary>A grouping of economies rather than a trade arrangement, e.g. the G7.</summary>
        GlobalEconomicGroup = 6,
    }
}
