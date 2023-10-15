using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.DragomeretskiyED.Sprint2.Task4.V15.Lib;

namespace Tyuiu.DragomeretskiyED.Sprint2.Task4.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 10;
            double y = 5;
            double res = ds.Calculate(x);
            double wait = 5.3;
            Assert.AreEqual(wait, res);
        }

        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 10;
            double y = 15;
            double res = ds.Calculate(x);
            double wait = 2.766;
            Assert.AreEqual(wait, res);
        }
    }
}
