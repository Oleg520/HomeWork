using System;
namespace HomeWork2lesson
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.Write("Введите минимальную температуру за сутки:");
            double tMin = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите максимальную температуру за сутки:");
            double tMax = Convert.ToDouble(Console.ReadLine());
            double tAverage = (tMax + tMin) / 2;
            Console.WriteLine($"Среднесуточная температура составляет {tAverage} градусов");

            Console.ReadLine();
            
        }
    }
}
