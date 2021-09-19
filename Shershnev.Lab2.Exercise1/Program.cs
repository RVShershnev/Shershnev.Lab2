using System;

namespace Shershnev.Lab2.Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Дана сторона квадрата, найти площадь, периметр и длину диагоналей.

            Console.WriteLine("Введите сторону квадрата");
            double a = Convert.ToDouble(Console.ReadLine());

            double S = a * a;
            Console.WriteLine("площадь: " + S);

            double P = 4 * a;
            Console.WriteLine("периметр: " + P);      

            double G = Math.Sqrt(2 * a * a);
            Console.WriteLine("диагональ: " + G);
        }
    }
}
