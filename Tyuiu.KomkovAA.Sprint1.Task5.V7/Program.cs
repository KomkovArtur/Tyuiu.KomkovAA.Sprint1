using Tyuiu.KomkovAA.Sprint1.Task5.V7.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataServise ds = new DataServise();
        Console.Title = "Спринт #0 | Выполнил: Комков А. А. | РППб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Class Math                                                        *");
        Console.WriteLine("* Задание #5                                                              *");
        Console.WriteLine("* Вариант #7                                                             *");
        Console.WriteLine("* Выполнил: Комков Артур Александрович | РППб-25-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Определить h – полное количество часов прошедших от начала суток до того*");
        Console.WriteLine("* момента (в первой половине дня), когда часовая стрелка повернулась на f *");
        Console.WriteLine("* f градусов (0<f<360, f – вещественное число).                           *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Введите градусы:");
        double f = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ответ:");
        Console.WriteLine(ds.AngleToHoursMinutes(f));
    }
}