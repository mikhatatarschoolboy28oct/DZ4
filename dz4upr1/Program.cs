using System;

class Program
{
    static int[] CreateArray(int size)
    {
        Random rnd = new Random();
        int[] arr = new int[size];
        for (int i = 0; i < size; i++)
            arr[i] = rnd.Next(1, 100);
        return arr;
    }

    static void PrintArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
            Console.Write(arr[i] + " ");
        Console.WriteLine();
    }

    static void Swap(int[] arr, int x, int y)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == x) arr[i] = y;
            else if (arr[i] == y) arr[i] = x;
        }
    }

    static void Main()
    {
        int[] arr = CreateArray(20);
        PrintArray(arr);

        Console.Write("Первое число: ");
        int x = int.Parse(Console.ReadLine());
        Console.Write("Второе число: ");
        int y = int.Parse(Console.ReadLine());

        Swap(arr, x, y);
        PrintArray(arr);
    }
}