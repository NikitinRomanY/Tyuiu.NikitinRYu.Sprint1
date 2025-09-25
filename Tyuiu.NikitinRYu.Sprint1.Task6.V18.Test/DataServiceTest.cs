using Tyuiu.NikitinRYu.Sprint1.Task6.V18.Lib;

namespace Tyuiu.NikitinRYu.Sprint1.Task6.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidNaturalNumber()
        {
            DataService ds = new DataService();
            string str = "123";
            bool wait = true;
            bool res = ds.CheckNumber(str);
            Assert.AreEqual(wait, res);
        }

        public void ZeroTest()
        {
            DataService ds = new DataService();
            string str = "0";
            bool wait = false;
            bool res = ds.CheckNumber(str);
            Assert.AreEqual(wait, res);
        }

        public void StartsWithZeroTest()
        {
            DataService ds = new DataService();
            string str = "012";
            bool wait = false;
            bool res = ds.CheckNumber(str);
            Assert.AreEqual(wait, res);
        }
    }
}