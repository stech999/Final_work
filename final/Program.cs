// Начало программы

Console.Clear();
// можно раскомментировать и проверить кажддый вариант:
string[] elements = { $"Hello", "world", ":-)" }; // первый вариант
// string[] elements = { $"1234", "1567", "-2", "computer science" }; // второй вариант
// string[] elements = { $"Russia", "Denmark", "Kazan" }; // третий вариант

PrintArray(elements);

void PrintArray(string[] el)
{
    for (int i = 0; i < el.Length; i++)
    {
        // Console.WriteLine($"Длина элемента ({el[i]}) в массиве равна: {el[i].Length}"); // Добавляем проверку работы вывода количества символов

        if (el[i].Length <= 3)
        {
            Console.WriteLine($" ");
            Console.WriteLine($"Элемент под номером {i} = ({el[i]}) имеет меньше или равен 3 символам");
            Console.WriteLine($" ");
        }

        else
        {
            Console.WriteLine($"Этот элемент ({el[i]}) не подходит под условие так как имеет больше 3 символов");
        }
    }
}