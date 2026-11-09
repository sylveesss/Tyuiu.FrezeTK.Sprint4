using System;

namespace Tyuiu.FrezeTK.Sprint4.Task6.V2.Lib
{
    public class DataService
    {
        public static string[] Calculate(string[] array)
        {
            return Array.FindAll(array, element => element.Length > 5);
        }
    }
}
