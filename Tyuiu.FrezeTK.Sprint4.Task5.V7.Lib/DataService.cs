using System;

namespace Tyuiu.FrezeTK.Sprint4.Task5.V7.Lib
{
    public class DataService
    {
        public static int Calculate(int[,] matrix)
        {
            int count = 0;
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j] < 0)
                    {
                        count++;
                    }
                }
            }

            return count;
        }
    }
}
