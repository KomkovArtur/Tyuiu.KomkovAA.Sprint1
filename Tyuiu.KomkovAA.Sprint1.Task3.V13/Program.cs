using Tyuiu.KomkovAA.Sprint1.Task3.V13.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataServise ds = new DataServise();
        Console.Title = "Спринт #0 | Выполнил: Комков А. А. | РППб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Операторы составного присваивания                                 *");
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #13                                                             *");
        Console.WriteLine("* Выполнил: Комков Артур Александрович | РППб-25-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая позволяет найти произведение цифр заданного *");
        Console.WriteLine("* трехзначного числа. Ответ округлите до 3 знаков после запятой.          *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Введите число:");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("результат произведения цифр:");
        Console.WriteLine(ds.MultiplyOfDigits(x));
    }
}