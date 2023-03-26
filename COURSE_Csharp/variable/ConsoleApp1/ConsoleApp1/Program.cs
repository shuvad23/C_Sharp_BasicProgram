using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the days: ");
            int days = int.Parse(Console.ReadLine());
            convetToMonthAndDays(days);
            Console.WriteLine();
            Console.ReadKey();
        }

        private static void convetToMonthAndDays(int days)
        {
            int months = days / 30;
            int day = days % 30;
            Console.WriteLine($"total {months} months and {day} days");
        }
    }
}
