using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PopkovSV.Sprint3.Task6.V19.Lib;

namespace Tyuiu.PopkovSV.Sprint3.Task6.V19.Test
{
    [TestClass]
    public class DatasServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataService ds = new DataService();

            int startValue = 10;
            int stopValue = 15;

            int res = ds.GetSumTheDivisors(startValue, stopValue);

            int wait = 16;

            Assert.AreEqual(wait, res);
        }
    }
}
