using Tyuiu.KomkovAA.Sprint1.Task6.V3.Lib;
namespace Tyuiu.KomkovAA.Sprint1.Task6.V3.Test
{
    [TestClass]
    public sealed class DataServiseTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataServise ds = new DataServise();

            string words = "ia lublu lol";
            string res = ds.LastLetterWord(words);
            Assert.AreEqual("aul", res);
        }
    }
}
