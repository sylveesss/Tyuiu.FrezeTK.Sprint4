using System;

namespace Tyuiu.FrezeTK.Sprint4.Task3.V5.Lib
{
    public class DataService
    {
        public static int Calculate(int[,] matrix)
        {
            int sum = 0;
            int rows = matrix.GetLength(0);

            for (int i = 0; i < rows; i++)
            {
                sum += matrix[i, 0];
            }

            return sum;
        }
    }
}
