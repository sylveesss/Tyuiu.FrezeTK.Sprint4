using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.FrezeTK.Sprint4.Task2.V22.Lib;

namespace Tyuiu.FrezeTK.Sprint4.Task2.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculateValid()
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 1, 2, 3, 4, 5, 6, 1 };
            int res = DataService.Calculate(nums);
            Assert.AreEqual(225, res); 
        }
    }
}
