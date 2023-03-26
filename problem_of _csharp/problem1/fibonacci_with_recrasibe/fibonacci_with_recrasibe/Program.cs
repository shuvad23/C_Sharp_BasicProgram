using System;

namespace fibonacci_with_recrasibe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter the value of number: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine();
            fibonacci(num);
            Console.WriteLine();
            Console.ReadKey();
        }

        private static void fibonacci(int num)
        {
            int a = 0;
            int b = 1;
            while (a <= num)
            {
                Console.WriteLine(a);
                int p = a + b;
                a = b;
                b = p;
            }
        }
    }
}
