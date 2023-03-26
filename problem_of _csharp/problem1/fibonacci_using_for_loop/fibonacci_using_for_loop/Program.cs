using System;

namespace fibonacci_using_for_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of number of time:");
            int n = int.Parse(Console.ReadLine());
            int a = 0;
            int b = 1;
            Console.WriteLine(a);
            Console.WriteLine(b);
            for (int i = 0; i <= n; i++) 
            {
                int p = a + b;
                Console.WriteLine(p);
                a = b;
                b = p;
                
                
            }
            Console.ReadKey();
        }
    }
}
