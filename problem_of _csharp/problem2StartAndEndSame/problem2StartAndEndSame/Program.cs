using System;

namespace problem2StartAndEndSame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("enter who many time the number are count:");
            int var1 = int.Parse(Console.ReadLine());
            int i = 1;
            for (i = 1; i <= var1; i++)
            {
                int last = i % 10;
                int fast = 0;
                int n = i/10;
                while(n>0)
                {
                    fast = n;
                    n = n / 10;
                }
                if(last==fast)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
