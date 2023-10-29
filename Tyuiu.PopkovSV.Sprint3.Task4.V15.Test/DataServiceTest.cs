using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PopkovSV.Sprint3.Task4.V15.Lib;

namespace Tyuiu.PopkovSV.Sprint3.Task4.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int startvalue = -5;
            int stopValue = 5;

            double res = ds.Calculate(startvalue, stopValue);

            double wait = 623.499;
            Assert.AreEqual(wait, res);
        }
    }
}
