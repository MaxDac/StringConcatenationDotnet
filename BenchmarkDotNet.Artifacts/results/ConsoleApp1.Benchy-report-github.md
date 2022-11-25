``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.819)
Intel Core i9-10900K CPU 3.70GHz, 1 CPU, 20 logical and 10 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
  DefaultJob : .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2


```
|                Method |      Mean |     Error |    StdDev |   Gen0 | Allocated |
|---------------------- |----------:|----------:|----------:|-------:|----------:|
|           Add2Strings |  8.404 ns | 0.2030 ns | 0.1899 ns | 0.0053 |      56 B |
|          Join2Strings | 20.328 ns | 0.3006 ns | 0.2510 ns | 0.0092 |      96 B |
|   Concat2StringAsSpan |  9.703 ns | 0.2404 ns | 0.2131 ns | 0.0053 |      56 B |
| Add2StringsWithCreate |  8.627 ns | 0.1326 ns | 0.1240 ns | 0.0053 |      56 B |
