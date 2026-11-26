using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.FrezeTK.Sprint4.Task2.V22.Lib;

namespace Tyuiu.FrezeTK.Sprint4.Task2.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] numsArray = { 1, 2, 3, 4, 5, 6, 1, 2, 3, 4, 5, 6, 1 };
            int res = ds.Calculate(numsArray);
            int wait = 225;

            Assert.AreEqual(wait, res);
        }
    }
}
