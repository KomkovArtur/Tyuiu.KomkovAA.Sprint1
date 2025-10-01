using Tyuiu.KomkovAA.Sprint1.Task1.V16.Lib;
namespace Tyuiu.KomkovAA.Sprint1.Task1.V16.Test
{
    [TestClass]
    public sealed class DataServiseTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataServise ds = new DataServise();
            double a = 1;
            double x = 2;
            double y = 3;
            var res = ds.Calculate(a, x, y);
            Assert.AreEqual(16, res);

        }
    }
}
