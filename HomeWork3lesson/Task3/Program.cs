using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {

            string reverse = Console.ReadLine();
            for (int i = reverse.Length - 1; i >= 0; i--)
                Console.Write(reverse[i]);
            Console.ReadKey();
        }
    }
}
