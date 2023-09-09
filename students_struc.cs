using System;

struct Student
{
    public string Name;
    public double Grade;
}

class Program
{
    static void Main()
    {
        // Инициализация студентов и их оценок
        Student[] students = new Student[]
        {
            new Student { Name = "Иван", Grade = 4.5 },
            new Student { Name = "Мария", Grade = 3.8 },
            new Student { Name = "Алексей", Grade = 4.2 },
            new Student { Name = "Елена", Grade = 3.9 },
            new Student { Name = "Сергей", Grade = 4.9 }
        };

        // Вычисление среднего балла
        double sum = 0;
        foreach (var student in students)
        {
            sum += student.Grade;
        }
        double averageGrade = sum / students.Length;

        // Вывод имен студентов с баллом выше среднего
        Console.WriteLine("Студенты с баллом выше среднего:");
        foreach (var student in students)
        {
            if (student.Grade > averageGrade)
            {
                Console.WriteLine(student.Name);
            }
        }
    }
}