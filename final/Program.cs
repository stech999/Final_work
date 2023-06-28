// Начало программы

Console.Clear();

string[] elements = { $"Hello", "2", "world", ":-)" };
// Console.Write($"{elements.Length}");
// Console.WriteLine();
PrintArray(elements);

void PrintArray(string[] el)
{
    for (int i = 0; i < el.Length; i++)
    {
        Console.Write($"Длина элемента ({el[i]}) в массиве равна: ");
        Console.WriteLine($"{el[i].Length} ");
    }
}