using System;

enum Grumpiness { Low, Medium, High, Extreme }

struct Ded
{
    public string Name;
    public Grumpiness Level;
    public string[] Phrases;
    public int Bruises;

    public Ded(string name, Grumpiness level, params string[] phrases)
    {
        Name = name;
        Level = level;
        Phrases = phrases;
        Bruises = 0;
    }

    public static int Beat(ref Ded ded, params string[] badWords)
    {
        int count = 0;

        foreach (string word in badWords)
        {
            foreach (string phrase in ded.Phrases)
            {
                if (phrase.ToLower().Contains(word.ToLower()))
                {
                    count++;
                    break;
                }
            }
        }

        ded.Bruises += count;
        return count;
    }
}

class Program
{
    static void Main()
    {
        Ded[] deds =
        {
            new Ded("Иван", Grumpiness.Low, "Ох, молодёжь..."),
            new Ded("Пётр", Grumpiness.Medium, "Гады!", "Куда катимся?"),
            new Ded("Степан", Grumpiness.High, "Проститутки!", "Гады!", "Чтоб вас!"),
            new Ded("Фёдор", Grumpiness.Extreme, "Проститутки!", "Гады!", "Сволочи!", "Тьфу!"),
            new Ded("Макар", Grumpiness.Medium, "Разболтались!", "Тишину надо!", "Эх!", "Ну и ну!", "Гады!")
        };

        for (int i = 0; i < deds.Length; i++)
        {
            int n = Ded.Beat(ref deds[i], "проститутки", "гады", "сволочи");
            Console.WriteLine($"{deds[i].Name} ({deds[i].Level}): фингалов {n}");
        }
    }
}