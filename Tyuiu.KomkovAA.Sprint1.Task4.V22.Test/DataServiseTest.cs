using Tyuiu.KomkovAA.Sprint1.Task4.V22.Lib;
namespace Tyuiu.KomkovAA.Sprint1.Task4.V22.Test
{
    [TestClass]
    public sealed class DataServiseTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataServise ds = new DataServise();
            double x = 10.0;
            double y = 10.0;
            Assert.AreEqual(0.011, ds.Calculate(x, y));
        }
    }
}
