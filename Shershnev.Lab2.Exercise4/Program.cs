using System;

namespace Shershnev.Lab2.Exercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Дерево
            Console.WriteLine("цифравая модель дерева");

            // Заданные атрибуты цифровой модели
            // Высота дерева (м).            
            double Height;
            // Периметр дерева (м). 
            double AveragePerimeter;
            // Количество корней. 
            int RootCount;
            // Количество веток. 
            int BranchCount;
            // Количество лет. 
            int YearOld;

            // Вычисляемые атрибуты цифровой модели
            // Площадь дерева.
            double Square;
            // Объем дерева
            double Volume;
            // Количество воды необходимое дереву (литры).
            double WaterDemand;
            // Количество удобрений необходимых дереву (кг).
            double FertilizationDemand;

            // Ввод информации в программу.         
            Console.WriteLine("Введите Height:");            
            string HeightStr = Console.ReadLine();            
            Height = Convert.ToDouble(HeightStr);
                              
            Console.WriteLine("Введите AveragePerimeter:");
            string AveragePerimeterStr = Console.ReadLine();
            AveragePerimeter = Convert.ToDouble(AveragePerimeterStr);
                              
            Console.WriteLine("Введите RootCount:");
            string RootCountStr = Console.ReadLine();
            RootCount = Convert.ToInt32(RootCountStr);
                            
            Console.WriteLine("Введите BranchCount:");
            string BranchCountStr = Console.ReadLine();
            BranchCount = Convert.ToInt32(BranchCountStr);
             
            Console.WriteLine("Введите YearOld:");
            string YearOldStr = Console.ReadLine();
            YearOld = Convert.ToInt32(YearOldStr);

            // Расчет вычисляемых атрибутов.

            // Вводим переменную R, чтоб упростить вычисления, т.к. соотношение используется несколько раз.
            double R = AveragePerimeter / (2 * Math.PI);
            Square = Math.PI * R * R;
            Volume = Square * Height;
            WaterDemand = 0.5 * Volume * YearOld + 0.3 * RootCount + 0.4 * RootCount;
            FertilizationDemand = Square + 0.5 * RootCount + 0.1 * RootCount;

            // Вывод информации на консоль.
            Console.WriteLine("Height: " + Height + " м.");
            Console.WriteLine("AveragePerimeter: " + AveragePerimeter + " м.");
            Console.WriteLine("RootCount: " + RootCount);
            Console.WriteLine("BranchCount: " + BranchCount);
            Console.WriteLine("YearOld: " + YearOld);            
            Console.WriteLine("Square: " + Square + " м^2.");
            Console.WriteLine("Volume: " + Volume + " м^3.");
            Console.WriteLine("WaterDemand: " + WaterDemand + " л.");
            Console.WriteLine("FertilizationDemand: " + FertilizationDemand + " кг.");            
        }
    }
}
