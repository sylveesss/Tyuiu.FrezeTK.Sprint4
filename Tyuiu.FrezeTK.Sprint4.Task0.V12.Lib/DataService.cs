using System;

namespace Tyuiu.FrezeTK.Sprint4.Task0.V12.Lib
{
    public class DataService
    {
        public static int GetMultEvenArrEl(int[] array)
        {
            int mult = 1;
            bool hasEven = false;

            foreach (int x in array)
            {
                if (x % 2 == 0)
                {
                    mult *= x;
                    hasEven = true;
                }
            }

            return hasEven ? mult : 0;
        }
    }
}
