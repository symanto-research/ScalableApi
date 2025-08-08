using Services.Interfaces;

namespace Services.Implementations;

public class LinqCopyService : IListCopyService
{
    public int[] Copy(int[] input) => input.Select(x => x).ToArray();
}