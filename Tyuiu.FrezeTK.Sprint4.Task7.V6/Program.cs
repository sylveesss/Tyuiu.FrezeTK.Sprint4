using System;
using Tyuiu.FrezeTK.Sprint4.Task7.V6.Lib;

namespace Tyuiu.FrezeTK.Sprint4.Task7.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Фрезе Т. К. | ИБКСб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнил: Фрезе Т. К. | ИБКСб-26-1                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Преобразуйте строку 458963214789 в матрицу 3 на 4 и подсчитайте         *");
            Console.WriteLine("* сумму нечетных чисел.                                                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string str = "458963214789";
            int n = 3;
            int m = 4;

            Console.WriteLine("Исходная строка: " + str);
            Console.WriteLine("Количество строк: " + n);
            Console.WriteLine("Количество столбцов: " + m);

            Console.WriteLine("\nСформированная матрица:");
            int index = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(str[index] + " \t");
                    index++;
                }
                Console.WriteLine();
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = DataService.Calculate(n, m, str);
            Console.WriteLine("Сумма нечетных чисел в матрице = " + res);

            Console.ReadKey();
        }
    }
}
