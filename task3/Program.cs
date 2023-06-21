using System;

class Program
{
    static void Main()
    {
        int m = 2;
        int n = 3;
        int result = AckermannFunction(m, n);
        Console.WriteLine("A({0}, {1}) = {2}", m, n, result);

        m = 3;
        n = 2;
        result = AckermannFunction(m, n);
        Console.WriteLine("A({0}, {1}) = {2}", m, n, result);
    }

    static int AckermannFunction(int m, int n)
    {
        if (m == 0)
            return n + 1;
        else if (n == 0)
            return AckermannFunction(m - 1, 1);
        else
            return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
    }
}