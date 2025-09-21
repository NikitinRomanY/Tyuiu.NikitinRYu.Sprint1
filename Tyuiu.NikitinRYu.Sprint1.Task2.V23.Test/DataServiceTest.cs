using Tyuiu.NikitinRYu.Sprint1.Task2.V23.Lib;

namespace Tyuiu.NikitinRYu.Sprint1.Task2.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 6;
            var res = ds.ConvertMinutesToSeconds(x);
            Assert.AreEqual(360, res);
        }
    }
}
