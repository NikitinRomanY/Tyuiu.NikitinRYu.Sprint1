using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.NikitinRYu.Sprint1.Task4.V10.Lib
{
        public class DataService : ISprint1Task4V10
        {
        public double Calculate(double a)
        {
            double cosA = Math.Cos(a);
            double sinA = Math.Sin(a);
            double sinSq = sinA * sinA;

            double numerator = 1 + cosA;
            double result = numerator / sinSq;

            return Math.Round(result, 3);
        }
    }
    }
