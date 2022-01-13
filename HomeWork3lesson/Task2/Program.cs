using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] phonebook = new string[,]
            {
                { "Vasya" , "vasilek@mail.ru"},
                { "Kostya", "konstantine@icloud.com"},
                { "Vladimir", "vovkamyaso@gmail.com"},
                { "Katya" , "katakomba@mail.ru"},
                { "Natalya", "krasotka228@bk.ru"}
            };

            for (int i = 0; i < phonebook.GetLength(0); i++)
            {
                for (int j = 0; j < phonebook.GetLength(1); j++)
                {
                    Console.Write($"{phonebook[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
