using Tyuiu.ShakinVV.Sprint1.Task2.V14.Lib;

namespace Tyuiu.ShakinVV.Sprint1.Task2.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValisExpression()
        {
            DataService ds = new DataService();
            int value = 300;
            int wait = 27;

            var res = ds.ConvertKelvinToCelsius(value);
            Assert.AreEqual(wait, res);
        }
    }
}
