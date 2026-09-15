using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.MikhailichenkoAI.Sprint1.Task7.V27.Lib
{
    public class DataService : ISprint1Task7V27
    {
        public double Calculate(double x, double y)
        {
            
            double term1Numerator = Math.Cos(Math.Pow(x, 2)) + Math.Sin(Math.Pow(y, 2));
            
            double term1Denominator = Math.Sin(y) + 1;
            
            double term1 = term1Numerator / term1Denominator;

            double term2Numerator = (x * y) - 12;
            
            double term2Denominator = 15 + Math.Cos(x);
            
            double term2 = term2Numerator / term2Denominator;

            double result = term1 - term2;

            return Math.Round(result, 3);
        }
    }
}
