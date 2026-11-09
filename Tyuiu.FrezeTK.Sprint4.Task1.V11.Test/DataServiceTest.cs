using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.FrezeTK.Sprint4.Task1.V11.Lib;

namespace Tyuiu.FrezeTK.Sprint4.Task1.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculateValid()
        {
            int[] nums = { 2, 6, 5, 5, 1, 5, 6, 5, 5, 1, 5, 3, 6, 6, 1, 6 }; 
            int res = DataService.Calculate(nums);
            Assert.AreEqual(32, res); 
        }
    }
}
