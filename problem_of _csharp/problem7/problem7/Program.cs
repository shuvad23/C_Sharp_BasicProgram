using System;

namespace problem7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("enter the value of Number:");
            int var1 = int.Parse(Console.ReadLine());
            factroialNumberiterator(var1);
            int var2 = factroialNumberRecursive(var1);
            Console.WriteLine($"the factroial number is {var2}");
            Console.WriteLine();
            Console.ReadKey();
        }
        public static void  factroialNumberiterator(int var1)
        {
            int result = 1;
            int n = var1;
            for (int i = 1; i < var1; i++)
            {
                result = result * n;
                n--;
            }
            Console.WriteLine($"the number of factroial {result}");
        }
        public static int  factroialNumberRecursive(int var1)
        {
            if (var1 == 0)
            {
                return 1;
            }
            else
            {
                return var1 * factroialNumberRecursive(var1 - 1);
            }
        }
    }
}
