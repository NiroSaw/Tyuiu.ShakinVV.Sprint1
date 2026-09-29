using Tyuiu.ShakinVV.Sprint1.Task6.V3.Lib;

//LastLetterWord(string)

namespace Tyuiu.ShakinVV.Sprint1.Task6.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string strTest = "Усынови меня, Вась.";
            DataService ds = new DataService();
            string res = ds.LastLetterWord(strTest);
            string wait = "ияь";
            Assert.AreEqual(wait, res);
        }
    }
}
