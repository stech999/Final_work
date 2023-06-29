// Начало программы

Console.Clear();

Console.Write($"Выберите номер примера: \n 1. Hello, 2, world, :-)\n 2. 1234, 1567, - 2, computer science \n 3. Russia, Denmark, Kazan");
Console.WriteLine("\n");


Console.Write($"Выберите вариант: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number == 1)
{
    string[] elements = { $"Hello", "2", "world", ":-)" };

    PrintArray(elements);

    void PrintArray(string[] el)
    {
        string[] newarray = new string[el.Length];

        for (int i = 0; i < el.Length; i++)
        {
            if (el[i].Length <= 3)
            {
                newarray[i] = el[i];
            }
        }
        Console.WriteLine("Итог:");
        Console.Write($"[{string.Join(" ", newarray)}]");
    }

}

else if (number == 2)
{
    string[] elements = { $"1234", "1567", "-2", "computer science" };

    PrintArray(elements);

    void PrintArray(string[] el)
    {
        string[] newarray = new string[el.Length];

        for (int i = 0; i < el.Length; i++)
        {
            if (el[i].Length <= 3)
            {
                newarray[i] = el[i];
            }
        }

        Console.WriteLine("Итог:");
        Console.Write($"[{string.Join(" ", newarray)}] ");
    }
}

else if (number == 3)
{
    string[] elements = { $"Russia", "Denmark", "Kazan" };

    PrintArray(elements);

    void PrintArray(string[] el)
    {
        string[] newarray = new string[el.Length];

        for (int i = 0; i < el.Length; i++)
        {
            if (el[i].Length <= 3)
            {
                newarray[i] = el[i];
            }
        }

        Console.WriteLine("Итог:");
        Console.Write($"[{string.Join(" ", newarray)}] ");
    }
}

else
{
    Console.Write("Такого номера нет, выберите один из трех вариантов");
}