using Tyuiu.RomanovichEN.Sprint1.Task5.V7.Lib;
namespace Tyuiu.RomanovichEN.Sprint1.Task5.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double f = 123;
            int wait = 4;
            var res = ds.AngleToHoursMinutes(f);
            Assert.AreEqual(wait, res);
        }
    }
}
