using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.KomkovAA.Sprint1.Task3.V13.Lib
{
    public class DataServise : ISprint1Task3V13
    {
        public double MultiplyOfDigits(double number)
        {
            double a1, a2, a3;
            a1 = (int) number % 10;
            a2 = (int) number % 100 / 10;
            a3 = (int) number / 100;
            return a1 * a2 * a3;
        }
    }
}
