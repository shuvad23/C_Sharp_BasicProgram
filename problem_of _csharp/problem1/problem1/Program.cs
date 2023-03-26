using System;

namespace problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("...................fibonacci series......");
            Console.WriteLine("Enter the value of N:");
            int n = int.Parse(Console.ReadLine());
            int a = 0;
            int b = 1;
            int p = 0;
            while (a <= n)
            {
                Console.WriteLine(a);
                p = a + b;
                a = b;
                b = p;
            }
            Console.ReadKey();
        }
    }
}