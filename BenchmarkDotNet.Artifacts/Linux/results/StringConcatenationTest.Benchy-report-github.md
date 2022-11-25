``` ini

BenchmarkDotNet=v0.13.2, OS=ubuntu 20.04
Intel Core i9-10900K CPU 3.70GHz, 1 CPU, 20 logical and 10 physical cores
.NET SDK=6.0.403
  [Host]     : .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
  DefaultJob : .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2


```
|                Method |     Mean |    Error |   StdDev |   Gen0 | Allocated |
|---------------------- |---------:|---------:|---------:|-------:|----------:|
|           Add2Strings | 14.76 ns | 0.210 ns | 0.196 ns | 0.0053 |      56 B |
|          Join2Strings | 33.56 ns | 0.367 ns | 0.307 ns | 0.0092 |      96 B |
|   Concat2StringAsSpan | 15.11 ns | 0.233 ns | 0.218 ns | 0.0053 |      56 B |
| Add2StringsWithCreate | 17.86 ns | 0.377 ns | 0.434 ns | 0.0053 |      56 B |
