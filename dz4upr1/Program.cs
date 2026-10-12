using System;

class Program
{
    static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    static void Main()
    {
        Console.WriteLine("Введите первое число:");
        int x=int.Parse(Console.ReadLine());
        Console.WriteLine("Введите второе число:");
        int y=int.Parse(Console.ReadLine());

        Swap(ref x, ref y);
        Console.WriteLine($"После обмена: x = {x}, y = {y}");

    }

}
