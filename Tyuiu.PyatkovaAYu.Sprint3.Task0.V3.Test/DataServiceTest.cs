using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PyatkovaAYu.Sprint3.Task0.V3.Lib;

namespace Tyuiu.PyatkovaAYu.Sprint3.Task0.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();

            int startValue = 1;
            int stoptValue = 10;

            double res = ds.GetSumSeries(startValue, stoptValue);

            double wait = 1.411;

            Assert.AreEqual(wait, res);
        }
    }
}
