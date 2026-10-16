using System;

class Program
{
    static long Fib(int n)
    {
        if(n<=0)
            throw new ArgumentException("n должно быть натуральным.");
        if(n==1 || n==2)
            return 1;
        return Fib(n-1)+Fib(n-2);
    }

    static void Main()
    {
        for (int i=1;i<=10;i++)
        Console.WriteLine(Fib(i));
    }
}