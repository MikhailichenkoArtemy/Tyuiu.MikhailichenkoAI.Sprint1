using Tyuiu.MikhailichenkoAI.Sprint1.Task5.V6.Lib;
namespace Tyuiu.MikhailichenkoAI.Sprint1.Task5.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            
            int k = 8;

            int wait = 1;

            
            var res = ds.Calculate(k);

            
            Assert.AreEqual(wait, res);
        }
    }
}
