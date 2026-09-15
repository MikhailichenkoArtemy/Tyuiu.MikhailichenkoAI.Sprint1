using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.MikhailichenkoAI.Sprint1.Task3.V14.Lib
{
    public class DataService : ISprint1Task3V14
    {
        public double ReverseNumber(double number)
        {
            
            int num = Convert.ToInt32(number);

            
            int a = num / 100;          
            int b = (num / 10) % 10;    
            int c = num % 10;          

            
            double result = (c * 100) + (b * 10) + a;


            return result;
        }
    }
}
