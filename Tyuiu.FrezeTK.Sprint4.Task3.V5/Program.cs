using System;
using Tyuiu.FrezeTK.Sprint4.Task3.V5.Lib;

namespace Tyuiu.FrezeTK.Sprint4.Task3.V5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int[,] mas2 = new int[5, 5] { { 3, 4, 8, 6, 3 },
                                          { 9, 9, 3, 6, 9 },
                                          { 5, 6, 7, 2, 3 },
                                          { 3, 6, 2, 3, 8 },
                                          { 5, 7, 2, 6, 4 } };

            int rows = mas2.GetUpperBound(0) + 1;
            int columns = mas2.Length / rows;

            Console.Title = "Спринт #4 | Выполнил: Фрезе Т. К. | ИБКСб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы. (статический ввод)                             *");
            Console.WriteLine("* Задание #3                                                              *");
            Tyuiu.FrezeTK.Sprint4.Task4.V30.LibConsole.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("* Выполнил: Фрезе Т. К. | ИБКСб-26-1                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* статическими значениями в диапазоне от 2 до 9. Найдите сумму элементов  *");
            Console.WriteLine("* в первом столбце массива.                                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Массив:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{mas2[i, j]} \t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Сумма элементов в первом столбце массива = " + ds.Calculate(mas2));

            Console.ReadKey();
        }
    }
}
