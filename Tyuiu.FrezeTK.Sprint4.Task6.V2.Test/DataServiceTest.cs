using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.FrezeTK.Sprint4.Task6.V2.Lib;

namespace Tyuiu.FrezeTK.Sprint4.Task6.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculateValid()
        {
            string[] sourceArray = { "Белый", "Черный", "Зеленый", "Синий", "Красный", "Желтый", "Фиолетовый" };

            string[] res = DataService.Calculate(sourceArray);


            Assert.AreEqual(5, res.Length);
        }
    }
}
