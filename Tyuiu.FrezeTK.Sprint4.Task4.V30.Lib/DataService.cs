using System;

namespace Tyuiu.FrezeTK.Sprint4.Task4.V30.Lib
{
    public class DataService
    {
        public static int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);
            int[,] resMatrix = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j] % 2 != 0)
                    {
                        resMatrix[i, j] = 0;
                    }
                    else
                    {
                        resMatrix[i, j] = matrix[i, j];
                    }
                }
            }

            return resMatrix;
        }
    }
}
