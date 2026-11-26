using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.FrezeTK.Sprint4.Task1.V11.Lib;

namespace Tyuiu.FrezeTK.Sprint4.Task1.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] numsArray = { 2, 6, 5, 5, 1, 5, 6, 5, 5, 5, 1, 5, 3, 6, 6, 1, 6 };
            int res = ds.Calculate(numsArray);
            int wait = 32;

            Assert.AreEqual(wait, res);
        }
    }
}
