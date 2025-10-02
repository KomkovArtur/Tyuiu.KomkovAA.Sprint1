using Tyuiu.KomkovAA.Sprint1.Task7.V19.Lib;
namespace Tyuiu.KomkovAA.Sprint1.Task7.V19.Test
{
    [TestClass]
    public sealed class DataServiseTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataServise ds = new DataServise();
            double x = 1;
            double wait = -5.159;
            var res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }
    }
}
