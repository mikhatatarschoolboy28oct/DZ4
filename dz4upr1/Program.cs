using System;

class Program
{
    static int Max(int a, int b)
    {
        return a>b ? a:b;
    }
    static void Main()
    {
        Console.Write("Введите первое число: ");
        int x = int.Parse(Console.ReadLine());
        Console.Write("Введите второе число: ");
        int y = int.Parse(Console.ReadLine());
        Console.WriteLine($"Наибольшее: {Max(x, y)}");
    }

}
