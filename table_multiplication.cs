using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число n: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Таблица умножения от 1 до " + n + ":");
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                Console.Write("{0,4}", i * j); // Используем форматирование для выравнивания
            }
            Console.WriteLine(); // Переход на новую строку после каждого числа i
        }
    }
}