using Tyuiu.NikitinRYu.Sprint1.Task7.V14.Lib;

namespace Tyuiu.NikitinRYu.Sprint1.Task7.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculation()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;
            double wait = 0.870;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
