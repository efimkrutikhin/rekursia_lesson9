using System;

class Program
{
    static void Main()
    {
        int N = 5;
        Console.WriteLine("Натуральные числа от {0} до 1:", N);
        PrintNaturalNumbers(N);
    }

    static void PrintNaturalNumbers(int num)
    {
        if (num > 0)
        {
            Console.Write(num + " ");
            PrintNaturalNumbers(num - 1);
        }
    }
}