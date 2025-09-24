using Tyuiu.NikitinRYu.Sprint1.Task5.V3.Lib;

namespace Tyuiu.NikitinRYu.Sprint1.Task5.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int k = 130985;
            int h = ds.Calculate(k);
            int wait = 9;
            Assert.AreEqual(wait, h);
        }
    }
}
