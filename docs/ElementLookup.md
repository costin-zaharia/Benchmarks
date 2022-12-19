# Element lookup - Contains

```
// * Summary *
BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.963)
13th Gen Intel Core i5-13600KF, 1 CPU, 20 logical and 14 physical cores
.NET SDK=7.0.100
[Host]             : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
.NET 6.0           : .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
.NET 7.0           : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
.NET Framework 4.8 : .NET Framework 4.8.1 (4.8.9105.0), X64 RyuJIT VectorSize=256
```

|                    Method |                  Job |              Runtime | Count |         Mean |     Error |     StdDev |       Median | Ratio | RatioSD |
|-------------------------- |--------------------- |--------------------- |------ |-------------:|----------:|-----------:|-------------:|------:|--------:|
|               ArrayLookup |             .NET 6.0 |             .NET 6.0 |  1000 |    85.431 us | 7.6849 us | 22.6591 us |    68.932 us |  3.37 |    0.68 |
|               ArrayLookup |             .NET 7.0 |             .NET 7.0 |  1000 |    30.551 us | 0.2846 us |  0.2377 us |    30.513 us |  1.00 |    0.00 |
|               ArrayLookup |   .NET Framework 4.8 |   .NET Framework 4.8 |  1000 |   177.992 us | 0.9969 us |  0.8837 us |   178.067 us |  5.82 |    0.06 |
|                           |                      |                      |       |              |           |            |              |       |         |
|      ImmutableArrayLookup |             .NET 6.0 |             .NET 6.0 |  1000 |    68.461 us | 0.2512 us |  0.2227 us |    68.428 us |  2.42 |    0.02 |
|      ImmutableArrayLookup |             .NET 7.0 |             .NET 7.0 |  1000 |    28.237 us | 0.2031 us |  0.1696 us |    28.175 us |  1.00 |    0.00 |
|      ImmutableArrayLookup |   .NET Framework 4.8 |   .NET Framework 4.8 |  1000 |   163.725 us | 0.8012 us |  0.6690 us |   163.687 us |  5.80 |    0.04 |
|                           |                      |                      |       |              |           |            |              |       |         |
|                ListLookup |             .NET 6.0 |             .NET 6.0 |  1000 |    67.600 us | 0.1518 us |  0.1268 us |    67.584 us |  2.38 |    0.01 |
|                ListLookup |             .NET 7.0 |             .NET 7.0 |  1000 |    28.434 us | 0.2021 us |  0.1688 us |    28.412 us |  1.00 |    0.00 |
|                ListLookup |   .NET Framework 4.8 |   .NET Framework 4.8 |  1000 |   506.703 us | 1.0910 us |  0.9671 us |   506.516 us | 17.82 |    0.11 |
|                           |                      |                      |       |              |           |            |              |       |         |
|       ImmutableListLookup |             .NET 6.0 |             .NET 6.0 |  1000 | 1,579.420 us | 6.1217 us |  4.7794 us | 1,578.335 us |  1.14 |    0.00 |
|       ImmutableListLookup |             .NET 7.0 |             .NET 7.0 |  1000 | 1,384.015 us | 4.4338 us |  3.9305 us | 1,384.125 us |  1.00 |    0.00 |
|       ImmutableListLookup |   .NET Framework 4.8 |   .NET Framework 4.8 |  1000 | 1,760.251 us | 6.7530 us |  5.9863 us | 1,759.171 us |  1.27 |    0.01 |
|                           |                      |                      |       |              |           |            |              |       |         |
|             HashSetLookup |             .NET 6.0 |             .NET 6.0 |  1000 |     2.431 us | 0.0077 us |  0.0069 us |     2.430 us |  1.17 |    0.01 |
|             HashSetLookup |             .NET 7.0 |             .NET 7.0 |  1000 |     2.080 us | 0.0068 us |  0.0057 us |     2.079 us |  1.00 |    0.00 |
|             HashSetLookup |   .NET Framework 4.8 |   .NET Framework 4.8 |  1000 |     4.175 us | 0.0052 us |  0.0043 us |     4.174 us |  2.01 |    0.01 |
|                           |                      |                      |       |              |           |            |              |       |         |
|    ImmutableHashSetLookup |             .NET 6.0 |             .NET 6.0 |  1000 |    31.570 us | 0.2139 us |  0.2001 us |    31.584 us |  1.92 |    0.02 |
|    ImmutableHashSetLookup |             .NET 7.0 |             .NET 7.0 |  1000 |    16.426 us | 0.0999 us |  0.0834 us |    16.415 us |  1.00 |    0.00 |
|    ImmutableHashSetLookup |   .NET Framework 4.8 |   .NET Framework 4.8 |  1000 |    27.901 us | 0.3944 us |  0.3689 us |    27.773 us |  1.70 |    0.03 |
|                           |                      |                      |       |              |           |            |              |       |         |
|          DictionaryLookup |             .NET 6.0 |             .NET 6.0 |  1000 |     2.414 us | 0.0054 us |  0.0042 us |     2.413 us |  1.09 |    0.01 |
|          DictionaryLookup |             .NET 7.0 |             .NET 7.0 |  1000 |     2.209 us | 0.0301 us |  0.0252 us |     2.201 us |  1.00 |    0.00 |
|          DictionaryLookup |   .NET Framework 4.8 |   .NET Framework 4.8 |  1000 |     3.986 us | 0.0052 us |  0.0043 us |     3.986 us |  1.80 |    0.02 |
|                           |                      |                      |       |              |           |            |              |       |         |
| ImmutableDictionaryLookup |             .NET 6.0 |             .NET 6.0 |  1000 |    25.688 us | 0.0706 us |  0.0626 us |    25.690 us |  1.46 |    0.01 |
| ImmutableDictionaryLookup |             .NET 7.0 |             .NET 7.0 |  1000 |    17.590 us | 0.0536 us |  0.0501 us |    17.597 us |  1.00 |    0.00 |
| ImmutableDictionaryLookup |   .NET Framework 4.8 |   .NET Framework 4.8 |  1000 |    32.691 us | 0.1233 us |  0.1029 us |    32.701 us |  1.86 |    0.01 |
