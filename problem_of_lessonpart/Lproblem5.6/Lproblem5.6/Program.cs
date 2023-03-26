using System;

namespace Lproblem5._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("enter the value of N:");
            string var = Console.ReadLine();
            Console.WriteLine(var);
            int var1 = var.Length;
            int i = 0;
            while (i < var1)
            {
                Console.Write(var[i]+" ");
                i++;
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
