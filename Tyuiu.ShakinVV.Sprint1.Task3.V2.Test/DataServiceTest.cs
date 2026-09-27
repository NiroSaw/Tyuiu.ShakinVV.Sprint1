using Tyuiu.ShakinVV.Sprint1.Task3.V2.Lib;

namespace Tyuiu.ShakinVV.Sprint1.Task3.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double priceNotebook = 1500;
            int amountNotebook = 2;
            double pricePencil = 500;
            int amountPencil = 4;
            double wait = 5000;

            var res = ds.PurchaseAmount(priceNotebook, amountNotebook, pricePencil, amountPencil);
            Assert.AreEqual(wait, res);
        }
    }
}
