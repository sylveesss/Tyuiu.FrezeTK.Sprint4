using System;

namespace Tyuiu.FrezeTK.Sprint4.Task7.V6.Lib
{
    public class DataService
    {
        public static int Calculate(int n, int m, string value)
        {
            int[,] matrix = new int[n, m];
            int sum = 0;
            int index = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = int.Parse(value[index].ToString());
                    if (matrix[i, j] % 2 != 0)
                    {
                        sum += matrix[i, j];
                    }
                    index++;
                }
            }

            return sum;
        }
    }
}
