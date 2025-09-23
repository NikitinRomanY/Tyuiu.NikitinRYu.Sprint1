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
            double a = 45;
            double wait = 1.707;
            var res = ds.Calculate(a);
            Assert.AreEqual(wait, res);
        }
    }
}
