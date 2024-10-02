// Задача 1: Напишите программу, которая бесконечно
// запрашивает целые числа с консоли. Программа
// завершается при вводе символа ‘q’ или при вводе
// числа, сумма цифр которого четная.
using System.Xml;

while (true)
{
    Console.Write("Введите целое число или 'q':  ");
    string input = Console.ReadLine();
    if (input.ToLower() == "q")
    {
        Console.WriteLine("Программа подошла к концу!");
        break;
    }
    if (int.TryParse(input, out int number))
    {
        if (IsSumDigitsEven(number))
        {
            Console.WriteLine($"Сумма цифр числа {number} чётная . Программа подошла к концу.");
            break;
        }
    }
    else
    {
        Console.WriteLine("Введите корректное число или 'q' для выходы из программы ");
        break;
    }
}

bool IsSumDigitsEven(int number)
{
    int sum = 0;
    while (number != 0)
    {
        sum = sum + number % 10;
        number = number / 10;
    }
    return sum % 2 == 0;
}
