using System;
using System.Threading;

class Program
{
    static string[][] d =
    {
        new[] { "#####", "#   #", "#   #", "#   #", "#####" },
        new[] { "  #  ", " ##  ", "  #  ", "  #  ", " ### " },
        new[] { "#####", "    #", "#####", "#    ", "#####" },
        new[] { "#####", "    #", "#####", "    #", "#####" },
        new[] { "#   #", "#   #", "#####", "    #", "    #" },
        new[] { "#####", "#    ", "#####", "    #", "#####" },
        new[] { "#####", "#    ", "#####", "#   #", "#####" },
        new[] { "#####", "    #", "    #", "    #", "    #" },
        new[] { "#####", "#   #", "#####", "#   #", "#####" },
        new[] { "#####", "#   #", "#####", "    #", "#####" }
    };

    static void Main()
    {
        while (true)
        {
            string s = Console.ReadLine().Trim().ToLower();
            if (s == "exit" || s == "закрыть") return;

            int n = int.Parse(s);

            if (n >= 0 && n <= 9)
                foreach (string line in d[n])
                    Console.WriteLine(line);
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Clear();
                Console.WriteLine("Ошибка: число должно быть от 0 до 9!");
                Thread.Sleep(3000);
                Console.ResetColor();
                Console.Clear();
            }
        }
    }
}