// Начало программы

Console.Clear();

string[] elements = { $"Hello, 2, world, :-)" };
PrintArray(elements);

void PrintArray(string[] el)
{
    for (int i = 0; i < el.Length; i++)
    {
        Console.Write($"{el[i]}");
    }
}