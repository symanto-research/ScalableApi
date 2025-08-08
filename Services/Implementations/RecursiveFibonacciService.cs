using Services.Interfaces;

namespace Services.Implementations;

public class RecursiveFibonacciService : IFibonacciService
{
    public long Calculate(int n)
    {
        if (n <= 1) return n;
        return Calculate(n - 1) + Calculate(n - 2);
    }
}