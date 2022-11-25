``` ini

BenchmarkDotNet=v0.13.2, OS=ubuntu 20.04
Intel Core i9-10900K CPU 3.70GHz, 1 CPU, 20 logical and 10 physical cores
.NET SDK=6.0.403
  [Host]     : .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
  DefaultJob : .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2


```
|                Method |     Mean |    Error |   StdDev |   Gen0 | Allocated |
|---------------------- |---------:|---------:|---------:|-------:|----------:|
|           Add2Strings | 15.06 ns | 0.362 ns | 0.355 ns | 0.0053 |      56 B |
|          Join2Strings | 34.16 ns | 0.731 ns | 0.648 ns | 0.0092 |      96 B |
|   Concat2StringAsSpan | 16.13 ns | 0.212 ns | 0.198 ns | 0.0053 |      56 B |
| Add2StringsWithCreate | 14.84 ns | 0.355 ns | 0.409 ns | 0.0053 |      56 B |
