using System;

namespace Lproblemlargenumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("enter the value of number:");
            int var = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int j =1;j<=var;j++)
            {
                Console.WriteLine("enter the value of number:");
            }
        }
    }
}
