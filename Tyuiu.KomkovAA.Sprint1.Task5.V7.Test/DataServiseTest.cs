using Tyuiu.KomkovAA.Sprint1.Task5.V7.Lib;
namespace Tyuiu.KomkovAA.Sprint1.Task5.V7.Test
{
    [TestClass]
    public sealed class DataServiseTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataServise ds = new DataServise();
            double a = 150;
            var res = ds.AngleToHoursMinutes(a);
            Assert.AreEqual(5, res);
        }
    }
}
