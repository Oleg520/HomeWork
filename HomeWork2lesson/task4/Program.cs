using System;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string shop = "супермаркет ПЕРЕКРЕСТОК";
            string ao = "АО ТД *Перекресток*";
            string milk = "Молоко 2.5% 1л";
            double priceMilk = 35.50;
            string egg = "Яйцо KINDER SURPRISE";
            double priceEgg = 99.90;
            string coffee = "Коффе 3в1 Nescafe";
            double priceCoffee = 5.50;
            string vodka = "Водка Beluga Noble 0,5";
            double priceVodka = 1250.00;
            string fish = "Сельдь в масле Балтийский Берег";
            double priceFish = 160.00;
            double sum;
            sum = priceCoffee + priceEgg + priceFish + priceMilk + priceVodka;
            long inn = 7728029110;
            string kassir = "Петрова Маргарита";

            Console.WriteLine($"|      {shop}    |"); 
            Console.WriteLine($"|       {ao}       |");
            Console.WriteLine("|           кассовый чек          |");
            Console.WriteLine("|---------------------------------|");
            Console.WriteLine($"|1:{milk}                 |");
            Console.WriteLine("|                       =   "+ String.Format("{0:F2}", priceMilk)+" |");
            Console.WriteLine($"|2:{egg}           |");
            Console.WriteLine("|                       =   " + String.Format("{0:F2}", priceEgg) + " |");
            Console.WriteLine($"|3:{coffee}              |");
            Console.WriteLine("|                       =    " + String.Format("{0:F2}", priceCoffee) + " |");
            Console.WriteLine($"|4:{vodka}         |");
            Console.WriteLine("|                       = " + String.Format("{0:F2}", priceVodka) + " |");
            Console.WriteLine($"|5.{fish}|");
            Console.WriteLine("|                       =  " + String.Format("{0:F2}", priceFish) + " |");
            Console.WriteLine("|ИТОГ                   = " + String.Format("{0:F2}", sum) + " |");
            Console.WriteLine("|---------------------------------|");
            Console.WriteLine($"|ИНН                    {inn}|");
            Console.WriteLine($"|{kassir} кассир-продавек|");
            Console.WriteLine($"|Сайт проверки ФПД:   www.nalog.ru|");
            Console.WriteLine($"|{DateTime.Now}        ПРИХОД|");
            Console.WriteLine("|********СПАСИБО ЗА ПОКУПКУ!******|");

        }
    }
}
