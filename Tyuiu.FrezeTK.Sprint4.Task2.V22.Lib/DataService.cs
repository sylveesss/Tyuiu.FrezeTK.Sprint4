using System;

namespace Tyuiu.FrezeTK.Sprint4.Task2.V22.Lib
{
    public class DataService
    {
        public static int Calculate(int[] array)
        {
            int product = 1;
            bool hasOdd = false;

            foreach (int x in array)
            {
                if (x % 2 != 0)
                {
                    product *= x;
                    hasOdd = true;
                }
            }

            return hasOdd ? product : 0;
        }
    }
}
