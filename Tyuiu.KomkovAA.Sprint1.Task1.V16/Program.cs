using Tyuiu.KomkovAA.Sprint1.Task1.V16.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataServise ds = new DataServise();
        Console.Title = "Спринт #0 | Выполнил: Комков А. А. | РППб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Организация ввода\\вывода в консольных приложениях                *");
        Console.WriteLine("* Задание #1                                                              *");
        Console.WriteLine("* Вариант #16                                                             *");
        Console.WriteLine("* Выполнил: Комков Артур Александрович | РППб-25-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая запрашивает у пользователя                  *");
        Console.WriteLine("* исходные данные, вычисляет результат по формуле x*5*a+2*y и печатает    *");
        Console.WriteLine("* печатает его на экране.                                                 *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Введите значение a:");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение x:");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение y:");
        double y = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(ds.Calculate(a, x, y));
        Console.ReadLine();
    }
}