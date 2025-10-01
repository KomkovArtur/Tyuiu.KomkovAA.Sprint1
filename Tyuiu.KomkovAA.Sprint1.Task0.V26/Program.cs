using Tyuiu.KomkovAA.Sprint1.Task0.V26.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataServise ds = new DataServise();
        Console.Title = "Спринт #0 | Выполнил: Комков А. А. | РППб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
        Console.WriteLine("* Задание #0                                                              *");
        Console.WriteLine("* Вариант #26                                                             *");
        Console.WriteLine("* Выполнил: Комков Артур Александрович | РППб-25-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая вычисляет выражение 4*5/2-18/2/3            *");
        Console.WriteLine("* и печатает результат на экране.                                         *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* 4*5/2-18/2/3                                                            *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(ds.Calculate());
        Console.ReadLine();
    }
}