using BenchmarkDotNet.Attributes;
using Services;
using Services.Implementations;

namespace ServiceBenchmark;

[MemoryDiagnoser]
public class ListBenchmarks
{
    private int[] _input;
    private int[] _output;
    private LinqCopyService _linq;
    private SpanCopyService _span;

    [Params(10, 1000, 10000)]
    public int Size;

    [GlobalSetup]
    public void Setup()
    {
        _input = Enumerable.Range(1, Size).ToArray();
        _output = new int[Size];
        _linq = new LinqCopyService();
        _span = new SpanCopyService();
    }

    [Benchmark]
    public int[] LinqImplementation() => _linq.Copy(_input);

    [Benchmark]
    public int[] SpanImplementation() => _span.Copy(_input); 

}