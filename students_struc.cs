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
        // ������������� ��������� � �� ������
        Student[] students = new Student[]
        {
            new Student { Name = "����", Grade = 4.5 },
            new Student { Name = "�����", Grade = 3.8 },
            new Student { Name = "�������", Grade = 4.2 },
            new Student { Name = "�����", Grade = 3.9 },
            new Student { Name = "������", Grade = 4.9 }
        };

        // ���������� �������� �����
        double sum = 0;
        foreach (var student in students)
        {
            sum += student.Grade;
        }
        double averageGrade = sum / students.Length;

        // ����� ���� ��������� � ������ ���� ��������
        Console.WriteLine("�������� � ������ ���� ��������:");
        foreach (var student in students)
        {
            if (student.Grade > averageGrade)
            {
                Console.WriteLine(student.Name);
            }
        }
    }
}