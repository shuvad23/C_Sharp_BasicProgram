using System;

namespace problem2_NumberDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the value of Number: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the value of digit: ");
            int digit = int.Parse(Console.ReadLine());
            int count=0;
            int n = num;
            while(n>0)
            {
                if (n % 10 == digit)
                {
                    count++;
                }
                n = n / 10;
            }
            Console.WriteLine($"number :{num}");
            Console.WriteLine($"digit {digit} is {count} time in this number");
            Console.ReadKey();

        }
    }
}
