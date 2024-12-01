using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnosers;
using Microsoft.Extensions.ObjectPool;

namespace Benchmark;

[CategoriesColumn]
[MemoryDiagnoser]
[SimpleJob(iterationCount: 25)]
public class ObjectPoolBenchmark
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

    private ObjectPool<List<int>> pool = default!;

    [GlobalSetup]
    public void GlobalSetup() => pool = ObjectPool.Create<List<int>>();

    [Benchmark]
    public int UsePooledList()
    {
        var value = 0;

        for (var i = 0; i < 100; i++)
        {
            var list = pool.Get();

            for (var j = 0; j < Size; j++) list.Add(j);
            value += list.Count;

            pool.Return(list);
        }

        return value;
    }

    [Benchmark(Baseline = true)]
    public int CreatNewList()
    {
        var value = 0;

        for (var i = 0; i < 100; i++)
        {
            var list = new List<int>();

            for (var j = 0; j < Size; j++) list.Add(j);

            value += list.Count;
        }

        return value;
    }

public class ListPolicy : IPooledObjectPolicy<List<int>>
{
    public List<int> Create() => [];

    public bool Return(List<int> obj)
    {
        obj.Clear();
        return true;
    }
}
}
