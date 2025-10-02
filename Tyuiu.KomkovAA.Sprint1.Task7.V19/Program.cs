using Tyuiu.KomkovAA.Sprint1.Task7.V19.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataServise ds = new DataServise();
        Console.Title = "Спринт #0 | Выполнил: Комков А. А. | РППб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
        Console.WriteLine("* Задание #7                                                              *");
        Console.WriteLine("* Вариант #19                                                             *");
        Console.WriteLine("* Выполнил: Комков Артур Александрович | РППб-25-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая вычисляет математическое выражение по       *");
        Console.WriteLine("* исходным значениям данных, вводимых пользователем. Ответ округлите до   *");
        Console.WriteLine("* 3 знаков после запятой.                                                 *");
        Console.WriteLine("*           7x^2                                                          *");
        Console.WriteLine("*  y = x - ------ + sin(x) + |x^(4) - x^(5)|                              *");
        Console.WriteLine("*           x^3                                                           *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Введите число x:");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ответ:");
        Console.WriteLine(ds.Calculate(x));

    }
}