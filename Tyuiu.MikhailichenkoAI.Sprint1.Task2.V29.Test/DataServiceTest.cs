using Tyuiu.MikhailichenkoAI.Sprint1.Task2.V29.Lib;
namespace Tyuiu.MikhailichenkoAI.Sprint1.Task2.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int seconds = 130;
            var res = ds.ConvertSecondsToHours(130);
            Assert.AreEqual(2, res); 
        }
    }
}
