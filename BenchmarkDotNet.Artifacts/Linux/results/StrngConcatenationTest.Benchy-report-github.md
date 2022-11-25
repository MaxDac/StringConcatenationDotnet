``` ini

BenchmarkDotNet=v0.13.2, OS=ubuntu 20.04
Intel Core i9-10900K CPU 3.70GHz, 1 CPU, 20 logical and 10 physical cores
.NET SDK=6.0.403
  [Host]     : .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
  DefaultJob : .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2


```
|                Method |     Mean |    Error |   StdDev |   Gen0 | Allocated |
|---------------------- |---------:|---------:|---------:|-------:|----------:|
|           Add2Strings | 15.73 ns | 0.380 ns | 0.569 ns | 0.0053 |      56 B |
|          Join2Strings | 33.12 ns | 0.588 ns | 0.521 ns | 0.0092 |      96 B |
|   Concat2StringAsSpan | 15.53 ns | 0.139 ns | 0.116 ns | 0.0053 |      56 B |
| Add2StringsWithCreate | 14.26 ns | 0.330 ns | 0.292 ns | 0.0053 |      56 B |
