using System;

namespace task5
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Введите порядковый номер текущего месяца:");
            int nowMonth = Convert.ToInt32(Console.ReadLine());
                   
            string monthTitle = "";
            switch (nowMonth)
            {
                case 1:
                    monthTitle  = "Январь";
                    break;
                case 2:
                    monthTitle = "Февраль";
                    break;
                case 3:
                    monthTitle = "Март";
                    break;
                case 4:
                    monthTitle = "Апрель";
                    break;
                case 5:
                    monthTitle = "Май";
                    break;
                case 6:
                    monthTitle = "Июнь";
                    break;
                case 7:
                    monthTitle = "Июль";
                    break;
                case 8:
                    monthTitle = "Август";
                    break;
                case 9:
                    monthTitle = "Сентябрь";
                    break;
                case 10:
                    monthTitle = "Октябрь";
                    break;
                case 11:
                    monthTitle = "Ноябрь";
                    break;
                case 12:
                    monthTitle = "Декабрь";
                    break;
                default:
                    Console.WriteLine("Укажите значение от 1 до 12");
                    break;

            }
            Console.WriteLine($"Текущий месяц {monthTitle}");

            Console.Write("Введите минимальную температуру за сутки:");
            double tMin = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите максимальную температуру за сутки:");
            double tMax = Convert.ToDouble(Console.ReadLine());
            double tAverage = (tMax + tMin) / 2;
            Console.WriteLine($"Среднесуточная температура составляет {tAverage} градусов");

            string joke = "";
            if (tAverage > 0 )
            {
                switch (nowMonth)
                {
                    case 1:
                        joke = "Дождливая зима";
                        break;
                    case 2:
                        joke = "Дождливая зима";
                        break;
                    case 12:
                        joke = "Дождливая зима";
                        break;
                }
                Console.WriteLine(joke);
            }
            

        }
    }
}
