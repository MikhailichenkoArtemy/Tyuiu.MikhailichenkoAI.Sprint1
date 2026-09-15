using Tyuiu.MikhailichenkoAI.Sprint1.Task3.V14.Lib;
namespace Tyuiu.MikhailichenkoAI.Sprint1.Task3.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            
            double number = 456;

            
            var res = ds.ReverseNumber(number);

            
            Assert.AreEqual(654.0, res);
        }
    }
}
