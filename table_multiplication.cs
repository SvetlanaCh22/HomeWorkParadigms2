using System;

class Program
{
    static void Main()
    {
        Console.Write("������� ����� n: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("������� ��������� �� 1 �� " + n + ":");
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                Console.Write("{0,4}", i * j); // ���������� �������������� ��� ������������
            }
            Console.WriteLine(); // ������� �� ����� ������ ����� ������� ����� i
        }
    }
}