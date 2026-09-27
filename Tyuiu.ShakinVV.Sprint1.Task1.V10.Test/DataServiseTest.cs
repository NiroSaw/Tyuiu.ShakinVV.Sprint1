using Tyuiu.ShakinVV.Sprint1.Task1.V10.Lib;

namespace Tyuiu.ShakinVV.Sprint1.Task1.V10.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds  = new DataService();
            double x = 1.0;
            double y = 2.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(1.5, res);
        }
    }
}
