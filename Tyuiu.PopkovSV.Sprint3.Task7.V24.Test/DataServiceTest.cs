using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PopkovSV.Sprint3.Task7.V24.Lib;

namespace Tyuiu.PopkovSV.Sprint3.Task7.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;

            double[] waitarr = new double[stopValue - startValue + 1];

            waitarr[0] = 7.83;
            waitarr[1] = 6.22;
            waitarr[2] = 6.36;
            waitarr[3] = 6.96;
            waitarr[4] = -0.52;
            waitarr[5] = 0;
            waitarr[6] = -3.3;
            waitarr[7] = -5.53;
            waitarr[8] = -6.25;
            waitarr[9] = -6.63;
            waitarr[10] = -8.24;

            double[] res = new double[stopValue - startValue + 1];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(waitarr, res);
        }
    }
}  