# IdentityServerBenchmarks
Benchmarks to show that PersistentGrantSerializer should be a singleton.

|               Method |           Mean |         Error |        StdDev |
|--------------------- |---------------:|--------------:|--------------:|
|  DeserializeInstance | 4,724,511.5 ns | 15,453.560 ns | 14,455.270 ns |
| DeserializeSingleton |    19,074.1 ns |    246.855 ns |    218.831 ns |
|       CreateInstance |       320.2 ns |      2.864 ns |      2.539 ns |
