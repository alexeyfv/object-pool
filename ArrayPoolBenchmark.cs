using System.Buffers;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnosers;

namespace Benchmark;

[CategoriesColumn]
[MemoryDiagnoser]
[SimpleJob(iterationCount: 25)]
public class ArrayPoolBenchmark
{
    [ParamsSource(nameof(GetLengths))]
    public int Size { get; set; }

    public static IEnumerable<int> GetLengths()
    {
        for (var i = 10; i < 100; i += 10) yield return i;
        for (var i = 100; i < 1000; i += 100) yield return i;
        for (var i = 1000; i < 10_000; i += 1000) yield return i;
        for (var i = 10_000; i < 100_000; i += 10_000) yield return i;
        for (var i = 100_000; i < 1_000_000; i += 100_000) yield return i;
        yield return 1_000_000;
    }

    [Benchmark]
    public int ArrayPoolRent()
    {
        var sum = 0;
        var pool = ArrayPool<int>.Shared;
        for (var i = 0; i < 100; i++)
        {
            int[] array = pool.Rent(Size);
            for (var j = 0; j < Size; j++) sum += array[j];
            pool.Return(array, true);
        }
        return sum;
    }

    [Benchmark(Baseline = true)]
    public int CreatNewList()
    {
        var sum = 0;
        for (int i = 0; i < 100; i++)
        {
            int[] array = new int[Size];
            for (var j = 0; j < Size; j++) sum += array[j];
        }
        return sum;
    }
}
