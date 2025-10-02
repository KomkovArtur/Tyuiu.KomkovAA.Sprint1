using Tyuiu.KomkovAA.Sprint1.Task6.V3.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataServise ds = new DataServise();
        Console.Title = "Спринт #0 | Выполнил: Комков А. А. | РППб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Class Math                                                        *");
        Console.WriteLine("* Задание #6                                                              *");
        Console.WriteLine("* Вариант #3                                                             *");
        Console.WriteLine("* Выполнил: Комков Артур Александрович | РППб-25-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу: пользователь вводит текст. Напечатать строку,       *");
        Console.WriteLine("* составленную из последних литер всех слов.                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Введите текст:");

        string a = Console.ReadLine();

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        string res = ds.LastLetterWord(a);

        Console.WriteLine(res);
    }
}