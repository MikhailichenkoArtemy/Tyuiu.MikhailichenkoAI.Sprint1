using Tyuiu.MikhailichenkoAI.Sprint1.Task1.V3.Lib;
namespace Tyuiu.MikhailichenkoAI.Sprint1.Task1.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2.0;
            double y = -3.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(4, res);
        }
    }
}
