using System;

class Program
{
    static void Main()
    {
        int M = 1;
        int N = 15;
        int sum = CalculateSum(M, N);
        Console.WriteLine("Сумма натуральных элементов от {0} до {1}: {2}", M, N, sum);
    }

    static int CalculateSum(int start, int end)
    {
        if (start > end)
            return 0;
        
        return start + CalculateSum(start + 1, end);
    }
}