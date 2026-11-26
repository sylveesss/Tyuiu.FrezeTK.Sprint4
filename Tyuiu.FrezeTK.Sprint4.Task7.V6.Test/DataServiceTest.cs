using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.FrezeTK.Sprint4.Task7.V6.Lib;

namespace Tyuiu.FrezeTK.Sprint4.Task7.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            int n = 3;
            int m = 4;
            int[,] mtrx = new int[n, m];
            string str = "458963214789";

            DataService ds = new DataService();
            int res = ds.Calculate(n, m, str);
            int wait = 34;

            Assert.AreEqual(wait, res);
        }
    }
}
