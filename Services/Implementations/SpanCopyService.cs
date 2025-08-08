using Services.Interfaces;

namespace Services.Implementations;

public class SpanCopyService : IListCopyService
{
    public int[] Copy(int[] input)
    {
        var result = new int[input.Length];
        input.AsSpan().CopyTo(result);
        return result;
    }
}