``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.819)
Intel Core i9-10900K CPU 3.70GHz, 1 CPU, 20 logical and 10 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
  DefaultJob : .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2


```
|                Method |      Mean |     Error |    StdDev |    Median |   Gen0 | Allocated |
|---------------------- |----------:|----------:|----------:|----------:|-------:|----------:|
|           Add2Strings |  8.277 ns | 0.1459 ns | 0.1365 ns |  8.260 ns | 0.0053 |      56 B |
|          Join2Strings | 20.201 ns | 0.3838 ns | 0.3402 ns | 20.169 ns | 0.0092 |      96 B |
|   Concat2StringAsSpan | 10.449 ns | 0.2540 ns | 0.2376 ns | 10.364 ns | 0.0053 |      56 B |
| Add2StringsWithCreate |  8.983 ns | 0.2407 ns | 0.5181 ns |  8.762 ns | 0.0053 |      56 B |
