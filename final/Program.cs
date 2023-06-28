// Начало программы

Console.Clear();

string[] elements = { $"Hello", "2", "world", ":-)" };

PrintArray(elements);

void PrintArray(string[] el)
{
    
    for (int i = 0; i < el.Length; i++)
    {

        // Console.WriteLine($"Длина элемента ({el[i]}) в массиве равна: {el[i].Length}"); // Добавляем проверку вывода количества символов

        if(el[i].Length <= 3)
        {
            Console.WriteLine($"{i} = ({el[i]}) ");
        }
    }
}