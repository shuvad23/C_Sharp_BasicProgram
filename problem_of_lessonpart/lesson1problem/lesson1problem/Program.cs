using System;

namespace lesson1problem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("enter the value of n:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the value of m:");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the value of m:");
            int x = int.Parse(Console.ReadLine());
           largest_number(n,m,x);
            Console.WriteLine();
            Console.ReadKey();
        }

        private static void largest_number(int n, int m,int x)
        {
            if (n > m)
            {
                if(n>x)
                {
                    Console.WriteLine("n is the largest number");

                }
            }
            else if (m>n)
            {
                if(m>x)
                {
                    Console.WriteLine("m is the largest number");
                }
            }
            else
            {
                Console.WriteLine("x is the largest number");
            }
            Console.ReadKey();
        }
    }
}
