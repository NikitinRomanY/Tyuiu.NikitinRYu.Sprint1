using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.NikitinRYu.Sprint1.Task1.V30.Lib;

namespace Tyuiu.NikitinRYu.Sprint1.Task1.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2.0;
            var res = ds.Calculate(x);
            Assert.AreEqual(2, res);
        }
    }
}

