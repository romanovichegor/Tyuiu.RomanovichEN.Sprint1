using Tyuiu.RomanovichEN.Sprint1.Task7.V23.Lib;
namespace Tyuiu.RomanovichEN.Sprint1.Task7.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 0;
            double wait = 1.265;
            Assert.AreEqual(ds.Calculate(x, y), wait);
        }
    }
}
