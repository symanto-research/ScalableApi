using BenchmarkDotNet.Attributes;
using Services;
using Services.Implementations;

namespace ServiceBenchmark;

[MemoryDiagnoser]
public class FibonacciBenchmarks
{
    private readonly LinearFibonacciService _linear = new();
    private readonly RecursiveFibonacciService _recursive = new();

    [Params(10, 20, 30, 40, 50)] public int n;

    [Benchmark]
    public long Recursive()
    {
        return _recursive.Calculate(n);
    }

    [Benchmark]
    public long Linear()
    {
        return _linear.Calculate(n);
    }
}