# CountryCodes

[![NuGet](https://img.shields.io/nuget/v/CountryCodes.svg)](https://www.nuget.org/packages/CountryCodes)

All countries and subdivisions based on ISO 3166

## Usage

### List all countries and subdivisions
```csharp
foreach (var country in Country.GetAllCountries())
{
    Console.WriteLine(country); // Two-letter code (e.g. "US")
    Console.WriteLine(country.Name);
    Console.WriteLine(country.TwoLetterCode); 
    Console.WriteLine(country.ThreeLetterCode);
    Console.WriteLine(country.NumericCode);

    foreach (var subdivision in country.Subdivisions)
    {
        Console.WriteLine(subdivision); // Subdivision code (e.g. "US-AL" for Alabama)
        Console.WriteLine(subdivision.Name);
        Console.WriteLine(subdivision.Code);
    }
}
```

### Static fields

```csharp
_ = Country.US.Name;                 // "United States"
_ = Country.US.TwoLetterCode;        // "US"
_ = Country.US.ThreeLetterCode;      // "USA"
_ = Country.US.NumericCode;          // 840

foreach (var item in Country.US.Subdivisions)
{
    _ = item.Code;                   // Code for state (e.g. "US-AL")
    _ = item.Name;                   // State name (e.g. "Alabama")
}
```

### Using the constructors

```csharp
_ = new Country("US") == Country.US;        // true
_ = new Country(840) == Country.US;         // true
_ = new Country("US") == new Country(840);  // true
_ = new Country("XX")                       // ArgumentException
```

```csharp
var alabama = new Subdivision("US-AL");
Console.WriteLine(alabama.Name); // "Alabama"
Console.WriteLine(alabama.Code); // "US-AL"
```

### Economic zones

Countries grouped by economic, customs, monetary or free-movement
arrangement. Unlike the ISO 3166 data above this is **not** a standard —
membership is political and changes, so it records when it was last verified.

```csharp
_ = EconomicZone.EU.Code;                   // "EU"
_ = EconomicZone.EU.Name;                   // "European Union"
_ = EconomicZone.EU.Type;                   // EconomicZoneType.EconomicUnion
_ = EconomicZone.EU.Members.Count;          // 27

_ = EconomicZone.EU.Contains(Country.BG);   // true
_ = EconomicZone.EU.Contains(Country.GB);   // false

_ = Country.BE.IsIn(EconomicZone.EU);       // true
_ = Country.DE.Zones;                       // EU, EA, EEA, SCHENGEN, G7

foreach (var zone in EconomicZone.GetAllZones())
{
    Console.WriteLine(zone);                // Code (e.g. "EU")
    Console.WriteLine(zone.Name);
    Console.WriteLine(zone.Type);

    foreach (var country in zone.Members)
        Console.WriteLine(country.Name);
}
```

```csharp
_ = new EconomicZone("EU") == EconomicZone.EU;   // true
_ = new EconomicZone("eu") == EconomicZone.EU;   // true, case-insensitive
_ = new EconomicZone("XX");                      // ArgumentException

EconomicZone.TryParse("EEA", out var zone);      // true
EconomicZone.TryParse("XX", out _);              // false
```

| Code | Zone | Type | Members |
|---|---|---|---|
| `EU` | European Union | `EconomicUnion` | 27 |
| `EA` | Euro area | `MonetaryUnion` | 21 |
| `EEA` | European Economic Area | `SingleMarket` | 30 |
| `EFTA` | European Free Trade Association | `FreeTradeArea` | 4 |
| `SCHENGEN` | Schengen Area | `FreeMovementArea` | 29 |
| `USMCA` | United States-Mexico-Canada Agreement | `FreeTradeArea` | 3 |
| `GCC` | Gulf Cooperation Council | `CustomsUnion` | 6 |
| `G7` | Group of Seven | `GlobalEconomicGroup` | 7 |

The zones overlap but are not interchangeable, which is what `Type` is for.
Ireland and Cyprus are in the EU but not Schengen; Switzerland is in Schengen
and EFTA but in neither the EU nor the EEA; Sweden and Poland are in the EU
but not the euro area.

Zones are modelled at **country** granularity. Some real arrangements are not:
the EU VAT area and the EU customs territory exclude parts of member states
(the Canary Islands, Büsingen) and include Monaco. Those are deliberately
absent rather than approximated, because a country-level answer to a
territory-level question is wrong in exactly the cases that matter.

## Benchmarks

> BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.9168/25H2/2025Update/HudsonValley2)  
13th Gen Intel Core i7-13700 2.10GHz, 1 CPU, 24 logical and 16 physical cores  
.NET SDK 10.0.400  
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3  
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3

Resolving countries and zones in a loop.

| Method                   | N       | Mean            | Error         | StdDev        | Allocated |
|------------------------- |-------- |----------------:|--------------:|--------------:|----------:|
| **CountryById**              | **1000**    |      **2,204.5 ns** |      **19.85 ns** |      **18.57 ns** |         **-** |
| CountryByCode            | 1000    |     42,866.1 ns |     115.47 ns |     102.36 ns |         - |
| CountryStaticFieldAccess | 1000    |        217.8 ns |       1.12 ns |       1.05 ns |         - |
| ZoneByCode               | 1000    |      3,692.2 ns |      12.59 ns |      11.77 ns |         - |
| ZoneStaticFieldAccess    | 1000    |      1,051.7 ns |       2.62 ns |       2.32 ns |         - |
| **CountryById**              | **10000**   |     **22,692.7 ns** |     **141.70 ns** |     **132.55 ns** |         **-** |
| CountryByCode            | 10000   |    412,547.7 ns |   1,824.02 ns |   1,706.19 ns |         - |
| CountryStaticFieldAccess | 10000   |      2,235.8 ns |      22.45 ns |      21.00 ns |         - |
| ZoneByCode               | 10000   |     39,330.5 ns |     243.17 ns |     215.56 ns |         - |
| ZoneStaticFieldAccess    | 10000   |     11,127.5 ns |      36.25 ns |      32.13 ns |         - |
| **CountryById**              | **100000**  |    **223,621.2 ns** |     **842.98 ns** |     **703.93 ns** |         **-** |
| CountryByCode            | 100000  |  4,141,862.0 ns |  28,578.02 ns |  26,731.90 ns |         - |
| CountryStaticFieldAccess | 100000  |     21,123.5 ns |     193.63 ns |     181.12 ns |         - |
| ZoneByCode               | 100000  |    369,808.6 ns |   1,478.17 ns |   1,310.36 ns |         - |
| ZoneStaticFieldAccess    | 100000  |    111,204.0 ns |     220.44 ns |     195.42 ns |         - |
| **CountryById**              | **1000000** |  **2,226,817.5 ns** |  **22,132.40 ns** |  **20,702.66 ns** |         **-** |
| CountryByCode            | 1000000 | 41,227,199.0 ns | 201,475.64 ns | 188,460.44 ns |         - |
| CountryStaticFieldAccess | 1000000 |    211,621.3 ns |   1,230.15 ns |   1,150.68 ns |         - |
| ZoneByCode               | 1000000 |  3,793,016.7 ns |  10,533.43 ns |   9,852.98 ns |         - |
| ZoneStaticFieldAccess    | 1000000 |  1,017,915.4 ns |   4,091.26 ns |   3,826.97 ns |         - |

Single operations on an already-resolved country or zone.

| Method                | Mean        | Error     | StdDev    | Median      | Gen0   | Allocated |
|---------------------- |------------:|----------:|----------:|------------:|-------:|----------:|
| CountryEqualsTrue     |   0.0033 ns | 0.0032 ns | 0.0030 ns |   0.0032 ns |      - |         - |
| CountryEqualsTrueNew  |  75.0247 ns | 0.4382 ns | 0.4099 ns |  75.0421 ns |      - |         - |
| CountryEqualsFalse    |   0.0032 ns | 0.0060 ns | 0.0056 ns |   0.0000 ns |      - |         - |
| CountryEqualsFalseNew | 269.5699 ns | 1.1699 ns | 0.9769 ns | 269.5760 ns |      - |         - |
| ZoneEqualsTrue        |   0.0078 ns | 0.0044 ns | 0.0041 ns |   0.0073 ns |      - |         - |
| ZoneEqualsTrueNew     |   5.8948 ns | 0.0333 ns | 0.0312 ns |   5.8826 ns |      - |         - |
| ZoneEqualsFalse       |   0.0031 ns | 0.0040 ns | 0.0038 ns |   0.0019 ns |      - |         - |
| ZoneEqualsFalseNew    |   6.6737 ns | 0.0385 ns | 0.0341 ns |   6.6685 ns |      - |         - |
| ZoneContainsTrue      |   2.7037 ns | 0.0276 ns | 0.0245 ns |   2.7003 ns |      - |         - |
| ZoneContainsFalse     |   2.5982 ns | 0.0321 ns | 0.0300 ns |   2.5888 ns |      - |         - |
| CountryIsIn           |   2.7349 ns | 0.0234 ns | 0.0219 ns |   2.7311 ns |      - |         - |
| ZoneName              |   1.7038 ns | 0.0323 ns | 0.0302 ns |   1.6876 ns |      - |         - |
| CountryZones          |   9.5497 ns | 0.1309 ns | 0.1225 ns |   9.5113 ns | 0.0020 |      32 B |
