using System;

class Program
{
    static void Main()
    {
        // Инициализация студентов и их оценок
        string[] names = { "Иван", "Мария", "Алексей", "Елена", "Сергей" };
        double[] grades = { 4.5, 3.8, 4.2, 3.9, 4.9 };

        // Вычисление среднего балла
        double sum = 0;
        for (int i = 0; i < grades.Length; i++)
        {
            sum += grades[i];
        }
        double averageGrade = sum / grades.Length;

        // Вывод имен студентов с баллом выше среднего
        Console.WriteLine("Студенты с баллом выше среднего:");
        for (int i = 0; i < grades.Length; i++)
        {
            if (grades[i] > averageGrade)
            {
                Console.WriteLine(names[i]);
            }
        }
    }
}