using Tyuiu.MikhailichenkoAI.Sprint1.Task0.V16.Lib;
namespace Tyuiu.MikhailichenkoAI.Sprint1.Task0.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression() 
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(-7, res);
        }
    }
}
