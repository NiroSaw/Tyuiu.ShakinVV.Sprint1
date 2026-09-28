using Tyuiu.ShakinVV.Sprint1.Task5.V4.Lib;

//int SecondsToHours(int time);

namespace Tyuiu.ShakinVV.Sprint1.Task5.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            int time = 13257;
            DataService ds = new DataService();  

            int result = ds.SecondsToHours(time);

            int wait = 3;
            Assert.AreEqual(wait, result);
        }
    }
}
