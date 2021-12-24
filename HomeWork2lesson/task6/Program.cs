using System;

namespace task6
{
    class Program
    {
        [Flags]
        enum Workday
        {
            Monday    = 0b_0000001,
            Tuesday   = 0b_0000010,
            Wednesday = 0b_0000100,
            Thursday  = 0b_0001000,
            Friday    = 0b_0010000,
            Saturday  = 0b_0100000,
            Sunday    = 0b_1000000,
        }
        static void Main(string[] args)
        {
            //работает в будни
            Workday office1 = Workday.Monday | Workday.Tuesday | Workday.Wednesday | Workday.Thursday | Workday.Friday;
            //работает в выходные
            Workday office2 = Workday.Saturday | Workday.Sunday;
            //работает без выходных
            Workday office3 = (Workday)0b_1111111;

            /*абсолютно не понимаю что тут делать и является ли правильным то, как я начал...*/
        }
    }
}
