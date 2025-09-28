using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.RomanovichEN.Sprint1.Task7.V23.Lib
{
    public class DataService : ISprint1Task7V23
    {
        public double Calculate(double x, double y)
        {
            return Math.Round(x - Math.Pow(10, Math.Sin(x)) + (20/(3*x)) + Math.Cos(x*x - y),3);
        }
    }
}
