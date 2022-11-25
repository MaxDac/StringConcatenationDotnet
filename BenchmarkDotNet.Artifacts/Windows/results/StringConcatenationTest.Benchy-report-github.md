``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.819)
Intel Core i9-10900K CPU 3.70GHz, 1 CPU, 20 logical and 10 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
  DefaultJob : .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2


```
|                Method |      Mean |     Error |    StdDev |   Gen0 | Allocated |
|---------------------- |----------:|----------:|----------:|-------:|----------:|
|           Add2Strings |  8.400 ns | 0.0864 ns | 0.0766 ns | 0.0053 |      56 B |
|          Join2Strings | 19.968 ns | 0.2156 ns | 0.2017 ns | 0.0092 |      96 B |
|   Concat2StringAsSpan |  9.392 ns | 0.2241 ns | 0.1986 ns | 0.0053 |      56 B |
| Add2StringsWithCreate | 11.558 ns | 0.0875 ns | 0.0819 ns | 0.0053 |      56 B |
