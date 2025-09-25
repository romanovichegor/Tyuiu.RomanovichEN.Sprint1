using Tyuiu.RomanovichEN.Sprint1.Task2.V1.Lib;
namespace Tyuiu.RomanovichEN.Sprint1.Task2.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 1;
            var res = ds.ConvertKmToM(x);
            Assert.AreEqual(0.622, res);
        }
    }
}
