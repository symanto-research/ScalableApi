using Services.Interfaces;

namespace Services.Implementations;

public class LinearFibonacciService : IFibonacciService
{
    public long Calculate(int n)
    {
        if (n <= 1) return n;

        long a = 0, b = 1;
        for (var i = 2; i <= n; i++)
        {
            var temp = a + b;
            a = b;
            b = temp;
        }

        return b;
    }
}