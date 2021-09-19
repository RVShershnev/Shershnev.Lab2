using System;

namespace Shershnev.Lab2.Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // f(x) = 1/7 + ln(|x/3|) + x-7 + max(x/3, 3) + cos(x/3)/sin(x/3) + 2^x + 1

            // Выводим информацию на консоль.
            Console.WriteLine("Введите x:");

            // Ждем от пользователя ввода строки.
            string xstr = Console.ReadLine();

            // Конвертируем строковой тип в тип double.
            double x = Convert.ToDouble(xstr);

            // Объявляем y.
            double y;
            y = 1 / 7.0 + Math.Log(Math.Abs(x / 3)) + x - 7 + Math.Max(x / 3, 3) + Math.Cos(x / 3) / Math.Sin(x / 3) + Math.Pow(2, x) + 1;

            // Выводим информацию о значение y.
            Console.WriteLine(y);
        }
    }
}
