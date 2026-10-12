using System;

class Program
{
    static bool Factorial(int n, out long result)
    {
        result = 1;
        try
        {
            checked
            {
                for (int i = 2; i <= n; i++)
                    result *= i;
            }
            return true;
        }
        catch (OverflowException)
        {
            result = 0;
            return false;
        }
    }

    static void Main()
    {
        Console.Write("Введите число: ");
        int n = int.Parse(Console.ReadLine());

        if (Factorial(n, out long res))
            Console.WriteLine($"{n}! = {res}");
        else
            Console.WriteLine("Переполнение!");
    }
}