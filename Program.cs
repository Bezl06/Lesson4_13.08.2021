using System;

namespace Lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача 2
            System.Console.WriteLine("Введите значения A и B (A<B) :");
            int summ = 0, a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            for (int i = a + 1; i < b; i++)
            {
                if (i % 2 == 1) System.Console.WriteLine($"Нечетное число : {i}");
                summ += i;
            }
            System.Console.WriteLine($"Сумма чисел располеженных между {a} и {b} равна : {summ}");

            //Задача 3
            System.Console.WriteLine("\nПрямоугольник");
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 18; j++)
                    if (i == 0 || i == 5 || j == 0 || j == 17) System.Console.Write("*");
                    else System.Console.Write(" ");
                System.Console.WriteLine();
            }
            System.Console.WriteLine("\nПрямоугольный треугольник");
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 13; j++)
                    if (i == 6 || j == 0 || i * 2 == j) System.Console.Write("*");
                    else System.Console.Write(" ");
                System.Console.WriteLine();
            }
            System.Console.WriteLine("\nРавносторонний треугольник");
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 13; j++)
                    if (i == 6 || j + i == 6 || j - i == 6) System.Console.Write("*");
                    else System.Console.Write(" ");
                System.Console.WriteLine();
            }
            System.Console.WriteLine("\nРомб");
            for (int i = 0; i < 13; i = i + 2)
            {
                for (int j = 0; j < 13; j++)
                    if (j + (i < 6 ? i : 12 - i) == 6 || j - (i < 6 ? i : 12 - i) == 6) System.Console.Write("*");
                    else System.Console.Write(" ");
                System.Console.WriteLine();
            }

            //Задача 4
            System.Console.WriteLine("Ваш начальный вклад равен 1000, введите желаемые проценты вашего депозита :");
            double months = 0, vklad = 1000, p = (double.Parse(Console.ReadLine())) / 100;
            for (months = 0; ; months++, vklad += vklad * p)
                if (vklad > 1100) break;
            System.Console.WriteLine($"Ваш вклад превысил 1100 руб. через {months} месяцов, и теперь он равен {vklad} руб.");
        }
    }
}
