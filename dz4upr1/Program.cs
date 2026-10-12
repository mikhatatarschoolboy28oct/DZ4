using System;
class Program
{
    static long Factorial(int n)
    {
        if(n<=1)
            return 1;
        return n*Factorial(n-1);   
    }

    static void Main()
    {
        Console.WriteLine("Введите число:");
        int x= int.Parse(Console.ReadLine());
        Console.WriteLine($"Факториал равен:{Factorial(x)}");
    }
}