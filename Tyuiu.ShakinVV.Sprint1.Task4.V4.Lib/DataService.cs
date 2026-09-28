using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ShakinVV.Sprint1.Task4.V4.Lib
{
    public class DataService : ISprint1Task4V4
    {
        public double Calculate(double x, double y)
        {
            var res = (1 + x * y) / Math.Abs(x + 2);
            var result = Math.Round(res, 3);
            return result;
        }
    }
}
