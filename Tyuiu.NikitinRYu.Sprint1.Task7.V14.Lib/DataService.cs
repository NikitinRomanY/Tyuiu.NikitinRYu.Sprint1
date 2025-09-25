using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.NikitinRYu.Sprint1.Task7.V14.Lib
{
    public class DataService : ISprint1Task7V14
    {
            public double Calculate(double x, double y)
            {
                if (x == 0)
                    throw new ArgumentException("x не может быть равен 0");

                double term1 = Math.Pow(2, -x);
                double term2 = 5.0 / (3 * x);
                double term3 = -Math.Cos(x * x);
                double term4 = Math.Sin(2 * x * y);

                double result = term1 + term2 + term3 + term4;
                return Math.Round(result, 3);
            }
        }
    }
