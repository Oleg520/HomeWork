using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Сейчас будет проверка на четность\nВведите чиcло:");
            int a;
            a = Convert.ToInt32(Console.ReadLine());
            int b = a % 2;
            if (b == 0)
            {
                Console.WriteLine($"Число {a} четное");
            }
            else 
            {
                Console.WriteLine($"Число {a} не четное");
            }

        }
    }
}
