using Tyuiu.ShakinVV.Sprint1.Task4.V4.Lib;

//Calculate(double, double)

namespace Tyuiu.ShakinVV.Sprint1.Task4.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 2;
            double wait = 1.25;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
