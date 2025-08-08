namespace Services;

public interface IListCopyService
{
    int[] Copy(int[] input);
}


public class LinqCopyService : IListCopyService
{
    public int[] Copy(int[] input) => input.Select(x => x).ToArray();
}

public class SpanCopyService : IListCopyService
{
    public int[] Copy(int[] input)
    {
        var result = new int[input.Length];
        input.AsSpan().CopyTo(result);
        return result;
    }
}