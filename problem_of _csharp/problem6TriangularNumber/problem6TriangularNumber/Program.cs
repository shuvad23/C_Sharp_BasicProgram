using System;

namespace problem6TriangularNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("enter the number: ");
            int var1 = int.Parse(Console.ReadLine());
            TriangularNumber(var1);
            Odd_and_even(var1);
            int var2 = TriangularNumber1(var1);
            Console.WriteLine($"the triangular number is {var2}");
            Console.WriteLine();
            Console.ReadKey();
        }

        private static void Odd_and_even(int var1)
        {
            if(var1%2==0)
            {
                Console.WriteLine($" the {var1} is a even .");
            }
            else
            {
                Console.WriteLine($"the {var1} is a odd.");
            }
        }

        private static void TriangularNumber(int var1)
        {
            int result = (var1 * (var1 + 1)) / 2;
            Console.WriteLine($"{var1} triangular number is {result}");
        }
        public static int  TriangularNumber1(int var1)
        {
            if(var1==0)
            {
                return 0;
            }
            else
            {
                return var1 + TriangularNumber1(var1 - 1);
            }
        }
    }
}
