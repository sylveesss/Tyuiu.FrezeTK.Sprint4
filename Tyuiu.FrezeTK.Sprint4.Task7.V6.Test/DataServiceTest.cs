using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.FrezeTK.Sprint4.Task7.V6.Lib;

namespace Tyuiu.FrezeTK.Sprint4.Task7.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculateValid()
        {
            string str = "458963214789";
            int n = 3;
            int m = 4;
            int res = DataService.Calculate(n, m, str);


            Assert.AreEqual(34, res);
        }
    }
}
