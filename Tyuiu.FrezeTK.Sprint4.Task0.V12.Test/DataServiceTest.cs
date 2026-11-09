using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.FrezeTK.Sprint4.Task0.V12.Lib;

namespace Tyuiu.FrezeTK.Sprint4.Task0.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMultEvenArrElValid()
        {
            int[] nums = { 4, 6, 2, 8, 4, 5, 6, 9, 8, 7 };
            int res = DataService.GetMultEvenArrEl(nums);
            Assert.AreEqual(73728, res);
        }
    }
}
