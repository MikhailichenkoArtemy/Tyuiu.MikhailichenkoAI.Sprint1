using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.MikhailichenkoAI.Sprint1.Task4.V6.Lib
{
    public class DataService : ISprint1Task4V6
    {
        public double Calculate(double x, double y)
        {
            
            double numerator = Math.Abs((y * y) - x);

            double denominator = x * y;

            double result = numerator / denominator;

            return Math.Round(result, 3);
        }
    }
}
