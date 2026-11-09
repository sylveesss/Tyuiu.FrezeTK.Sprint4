using System;

namespace Tyuiu.FrezeTK.Sprint4.Task1.V11.Lib
{
    public class DataService
    {
        public static int Calculate(int[] array)
        {
            int sum = 0;

            foreach (int x in array)
            {
                if (x % 2 == 0)
                {
                    sum += x;
                }
            }

            return sum;
        }
    }
}
