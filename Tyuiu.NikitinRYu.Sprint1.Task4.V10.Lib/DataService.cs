using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.NikitinRYu.Sprint1.Task4.V10.Lib
{
        public class DataService : ISprint1Task4V10
        {
        public double Calculate(double a)
        {
            double aRad = a * Math.PI / 180.0;

            double cosA = Math.Cos(aRad);
            double sin2A = Math.Sin(2 * aRad);

            double numerator = 1 + cosA;
            double result = numerator / sin2A;

            return Math.Round(result, 3);
        }
    }
    }
