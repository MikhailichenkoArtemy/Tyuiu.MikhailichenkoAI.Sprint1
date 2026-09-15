using Tyuiu.MikhailichenkoAI.Sprint1.Task6.V7.Lib;
namespace Tyuiu.MikhailichenkoAI.Sprint1.Task6.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            
            string text = "Привет мир";

            
            string wait = "Приве ми";

            
            var res = ds.DeleteLastLetter(text);

            
            Assert.AreEqual(wait, res);
        }
    }
}
