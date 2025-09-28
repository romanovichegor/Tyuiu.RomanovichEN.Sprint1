using Tyuiu.RomanovichEN.Sprint1.Task6.V9.Lib;
namespace Tyuiu.RomanovichEN.Sprint1.Task6.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            string str = "abc";
            string wait = "cab";
            str = ds.MoveLetterToStart(str);
            Assert.AreEqual(str, wait);
        }
    }
}
