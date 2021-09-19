using System;

namespace Shershnev.Lab2.Exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // f(x, y, z) = 1 / 7 + ln(| y / 3 |) + z - 7 + max(x / 3, 3)

            // Выводим информацию на консоль.
            Console.WriteLine("Введите x:");

            // Ждем от пользователя ввода строки для x.
            string xstr = Console.ReadLine();
            // Ждем от пользователя ввода строки для y.
            string ystr = Console.ReadLine();
            // Ждем от пользователя ввода строки для z.
            string zstr = Console.ReadLine();

            // Конвертируем строковой тип в тип double.
            double x = Convert.ToDouble(xstr);
            // Конвертируем строковой тип в тип double.
            double y = Convert.ToDouble(ystr);
            // Конвертируем строковой тип в тип double.
            double z = Convert.ToDouble(zstr);

            // Объявляем f.
            double f;
            f = 1 / 7.0 + Math.Log(Math.Abs(y / 3)) + z - 7 + Math.Max(x / 3, 3);

            // Выводим информацию о значение f.
            Console.WriteLine(f);
        }
    }
}
