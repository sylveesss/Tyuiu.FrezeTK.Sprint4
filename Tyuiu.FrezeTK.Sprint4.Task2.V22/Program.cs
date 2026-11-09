using System;
using Tyuiu.FrezeTK.Sprint4.Task2.V22.Lib;

namespace Tyuiu.FrezeTK.Sprint4.Task2.V22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Фрезе Т. К. | ИБКСб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (генератор случайных чисел)                    *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #22                                                             *");
            Console.WriteLine("* Выполнил: Фрезе Т. К. | ИБКСб-26-1                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Подсчитать произведение нечетных элементов массива, заполненного        *");
            Console.WriteLine("* случайными числами.                                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int len = 13;
            int[] array = new int[len];
            Random rnd = new Random();

            Console.WriteLine("Количество элементов массива: " + len);

            for (int i = 0; i < len; i++)
            {
                array[i] = rnd.Next(1, 7); 
            }

            Console.WriteLine("Сгенерированный массив:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + (i < array.Length - 1 ? ", " : ""));
            }
            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = DataService.Calculate(array);
            Console.WriteLine("Произведение нечетных элементов массива = " + res);

            Console.ReadKey();
        }
    }
}
