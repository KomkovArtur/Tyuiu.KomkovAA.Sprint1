using Tyuiu.KomkovAA.Sprint1.Task0.V26.Lib;
namespace Tyuiu.KomkovAA.Sprint1.Task0.V26.Test
{
    [TestClass]
    public sealed class DataServiseTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataServise ds = new DataServise();
            var res = ds.Calculate();
            Assert.AreEqual(7, res);
        }
    }
}
