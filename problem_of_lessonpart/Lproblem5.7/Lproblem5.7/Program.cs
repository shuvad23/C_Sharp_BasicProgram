using System;

namespace Lproblem5._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("enter the value of string:");
            string var = Console.ReadLine();
            int var1 = var.Length;
            int i = 0;
            int countstr = 0;
            int countint = 0;
            int countspi = 0;
            while(i<var1)
            {
                if ((var[i] >= 'a' && var[i] <= 'z') || (var[i]>= 'A' && var[i] <= 'Z')) 
                {
                    countstr++;
                }
                else if(var[i]>='0' && var[i]<='9')
                {                                      
                    countint++;
                }
                else
                {
                    countspi++;
                }
                i++;
            }
            Console.WriteLine($"string value{countstr},integer value{countint},spical charater{countspi}...");
            Console.ReadKey();
        }
    }
}
