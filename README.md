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

## Benchmarks

> BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3593/23H2/2023Update/SunValley3)  
13th Gen Intel Core i7-13700, 1 CPU, 24 logical and 16 physical cores  
.NET SDK 8.0.300  
  [Host]     : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2  
  DefaultJob : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2

| Method                   | N       | Mean               | Error           | StdDev          | Median             | Allocated |
|------------------------- |-------- |-------------------:|----------------:|----------------:|-------------------:|----------:|
| CountryById              | 1000    |      2,389.8790 ns |      10.4699 ns |       8.7428 ns |      2,387.9715 ns |         - |
| CountryByCode            | 1000    |     81,024.7900 ns |     271.3211 ns |     253.7939 ns |     81,044.9463 ns |         - |
| CountryStaticFieldAccess | 1000    |        208.0466 ns |       0.8205 ns |       0.7675 ns |        207.8247 ns |         - |
| CountryEqualsTrue        | 1000    |          0.0005 ns |       0.0010 ns |       0.0010 ns |          0.0000 ns |         - |
| CountryEqualsTrueNew     | 1000    |        182.6032 ns |       0.7119 ns |       0.6659 ns |        182.7221 ns |         - |
| CountryEqualsFalse       | 1000    |          0.0065 ns |       0.0050 ns |       0.0046 ns |          0.0054 ns |         - |
| CountryEqualsFalseNew    | 1000    |        605.2488 ns |       8.3654 ns |       7.4157 ns |        605.9461 ns |         - |
| CountryById              | 10000   |     24,135.4159 ns |     134.2165 ns |     125.5462 ns |     24,102.3529 ns |         - |
| CountryByCode            | 10000   |    804,314.0560 ns |   4,967.4101 ns |   4,646.5185 ns |    805,193.8477 ns |         - |
| CountryStaticFieldAccess | 10000   |      2,003.0091 ns |      12.9029 ns |      12.0694 ns |      2,003.7109 ns |         - |
| CountryEqualsTrue        | 10000   |          0.0003 ns |       0.0008 ns |       0.0008 ns |          0.0000 ns |         - |
| CountryEqualsTrueNew     | 10000   |        183.0074 ns |       0.8514 ns |       0.7964 ns |        183.1840 ns |         - |
| CountryEqualsFalse       | 10000   |          0.0018 ns |       0.0029 ns |       0.0026 ns |          0.0005 ns |         - |
| CountryEqualsFalseNew    | 10000   |        615.3867 ns |      10.8206 ns |      10.1216 ns |        613.0751 ns |         - |
| CountryById              | 100000  |    239,643.2487 ns |   1,062.3031 ns |     993.6790 ns |    239,393.2373 ns |         - |
| CountryByCode            | 100000  |  8,032,422.8125 ns |  49,702.5701 ns |  46,491.8149 ns |  8,029,992.1875 ns |       6 B |
| CountryStaticFieldAccess | 100000  |     19,872.5524 ns |      72.8110 ns |      68.1075 ns |     19,859.8618 ns |         - |
| CountryEqualsTrue        | 100000  |          0.0031 ns |       0.0042 ns |       0.0040 ns |          0.0020 ns |         - |
| CountryEqualsTrueNew     | 100000  |        183.3448 ns |       0.7262 ns |       0.6792 ns |        183.3051 ns |         - |
| CountryEqualsFalse       | 100000  |          0.0026 ns |       0.0034 ns |       0.0032 ns |          0.0002 ns |         - |
| CountryEqualsFalseNew    | 100000  |        610.9723 ns |      11.9035 ns |      14.1703 ns |        610.2311 ns |         - |
| CountryById              | 1000000 |  2,380,388.9323 ns |   6,039.4146 ns |   5,649.2722 ns |  2,380,687.5000 ns |       2 B |
| CountryByCode            | 1000000 | 84,550,160.0000 ns | 391,468.2112 ns | 366,179.6077 ns | 84,580,233.3333 ns |      67 B |
| CountryStaticFieldAccess | 1000000 |    199,805.0163 ns |     491.5580 ns |     459.8036 ns |    199,977.6611 ns |         - |
| CountryEqualsTrue        | 1000000 |          0.0040 ns |       0.0051 ns |       0.0048 ns |          0.0020 ns |         - |
| CountryEqualsTrueNew     | 1000000 |        183.2498 ns |       1.1114 ns |       1.0396 ns |        183.0645 ns |         - |
| CountryEqualsFalse       | 1000000 |          0.0044 ns |       0.0050 ns |       0.0047 ns |          0.0026 ns |         - |
| CountryEqualsFalseNew    | 1000000 |        622.5405 ns |      11.0644 ns |      10.3496 ns |        623.3470 ns |         - |
