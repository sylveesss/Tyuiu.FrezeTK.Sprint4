using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.FrezeTK.Sprint4.Task3.V5.Lib;

namespace Tyuiu.FrezeTK.Sprint4.Task3.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculateValid()
        {
            int[,] matrix = new int[5, 5]
            {
                { 3, 4, 8, 6, 3 },
                { 9, 9, 3, 6, 9 },
                { 5, 6, 7, 2, 3 },
                { 3, 6, 2, 3, 8 },
                { 5, 7, 2, 6, 4 }
            };

            int res = DataService.Calculate(matrix);
            Assert.AreEqual(25, res);
        }
    }
}
