using Tyuiu.NikitinRYu.Sprint1.Task4.V10.Lib;


namespace Tyuiu.NikitinRYu.Sprint1.Task4.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
            [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double a = 60;
            double wait = 0.512;
            var res = ds.Calculate(a);
            Assert.AreEqual(wait, res);
        }
    }
}
