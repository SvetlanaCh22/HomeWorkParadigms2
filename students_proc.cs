using System;

class Program
{
    static void Main()
    {
        // ������������� ��������� � �� ������
        string[] names = { "����", "�����", "�������", "�����", "������" };
        double[] grades = { 4.5, 3.8, 4.2, 3.9, 4.9 };

        // ���������� �������� �����
        double sum = 0;
        for (int i = 0; i < grades.Length; i++)
        {
            sum += grades[i];
        }
        double averageGrade = sum / grades.Length;

        // ����� ���� ��������� � ������ ���� ��������
        Console.WriteLine("�������� � ������ ���� ��������:");
        for (int i = 0; i < grades.Length; i++)
        {
            if (grades[i] > averageGrade)
            {
                Console.WriteLine(names[i]);
            }
        }
    }
}