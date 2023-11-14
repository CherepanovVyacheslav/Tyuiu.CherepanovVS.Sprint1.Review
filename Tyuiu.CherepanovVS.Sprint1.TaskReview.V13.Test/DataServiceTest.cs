using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.CherepanovVS.Sprint1.TaskReview.V13.Lib;

namespace Tyuiu.CherepanovVS.Sprint1.TaskReview.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 5;
            double y = 2;
            double wait = 0.345;
            double z = ds.Calculate(x, y);
            double res = Math.Round(z, 3);
            Assert.AreEqual(wait, res);
        }
    }
}
