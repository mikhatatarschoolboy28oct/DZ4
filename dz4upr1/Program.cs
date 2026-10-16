using System;

class Program
{
    
    static int Calc(ref long product, out long average, params int[] arr)
    {
        int sum = 0;
        product = 1;

        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
            product *= arr[i];
        }

        average = sum / arr.Length;
        return sum;
    }

    static void Main()
    {
        long product = 0;
        long average;

        int sum = Calc(ref product, out average, 2, 4, 6, 8);

        Console.WriteLine("Сумма: " + sum);
        Console.WriteLine("Произведение: " + product);
        Console.WriteLine("Среднее: " + average);       
    }
}