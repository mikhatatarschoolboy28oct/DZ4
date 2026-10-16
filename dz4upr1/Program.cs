using System;

class Program
{
    static int Gcd(int a, int b)
    {
        while (b != 0)
        {
            int r = a % b;
            a = b;
            b = r;
        }
        return a;
    }

    
    static int Gcd(int a, int b, int c)
    {
        return Gcd(Gcd(a, b), c);
    }

    static void Main()
    {
        Console.WriteLine(Gcd(48, 18));       
        Console.WriteLine(Gcd(48, 18, 30));   
        Console.WriteLine(Gcd(12, 25, 7));    
    }
}