using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.FrezeTK.Sprint4.Task6.V2.Lib;

namespace Tyuiu.FrezeTK.Sprint4.Task6.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            string[] colors = new string[] { "Белый", "Черный", "Зеленый", "Синий", "Красный", "Желтый", "Фиолетовый" };
            string[] res = ds.Calculate(colors);
            string[] wait = new string[] { "Черный", "Зеленый", "Красный", "Желтый", "Фиолетовый" };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
