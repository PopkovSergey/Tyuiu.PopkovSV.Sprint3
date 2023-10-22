using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PopkovSV.Sprint3.Task3.V15.Lib;

namespace Tyuiu.PopkovSV.Sprint3.Task3.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidMinCharCount()
        {
            DataService ds = new DataService();

            string str = "lrmmse mg sermmmrt";
            char chr = 'm';

            double res = ds.GetMinCharCount(str, chr);

            int wait = 2;

            Assert.AreEqual(wait, res);
        }
    }
}
