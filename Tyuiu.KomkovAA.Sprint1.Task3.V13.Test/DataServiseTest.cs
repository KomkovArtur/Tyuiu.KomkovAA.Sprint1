using Tyuiu.KomkovAA.Sprint1.Task3.V13.Lib;
namespace Tyuiu.KomkovAA.Sprint1.Task3.V13.Test
{
    [TestClass]
    public sealed class DataServiseTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataServise ds = new DataServise();
            double x = 228;
            Assert.AreEqual(32, ds.MultiplyOfDigits(x));
        }
    }
}
