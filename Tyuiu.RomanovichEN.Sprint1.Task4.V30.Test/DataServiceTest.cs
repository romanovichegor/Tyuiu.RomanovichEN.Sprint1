﻿using Tyuiu.RomanovichEN.Sprint1.Task4.V30.Lib;
namespace Tyuiu.RomanovichEN.Sprint1.Task4.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1 ; double y = 2;
            double wait = 9;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
