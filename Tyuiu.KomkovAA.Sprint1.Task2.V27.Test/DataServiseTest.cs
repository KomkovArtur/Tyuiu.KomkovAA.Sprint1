using Tyuiu.KomkovAA.Sprint1.Task2.V27.Lib;
namespace Tyuiu.KomkovAA.Sprint1.Task2.V27.Test
{
    [TestClass]
    public sealed class DataServiseTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataServise ds = new DataServise();
            int x = 8;
            int y = ds.CalculateSquarePerimetr(x);
            Assert.AreEqual(32, y);
        }
    }
}
