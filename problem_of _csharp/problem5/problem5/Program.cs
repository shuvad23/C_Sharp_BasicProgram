using System;

namespace problem5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("enter the value of number :");
            int var = int.Parse(Console.ReadLine());
            for (int i=1;i<=var;i++)
            {
                int fast =0;
                int n = i / 10;
                while(n>2)
                {
                    fast = n;
                    n = n / 10;
                }
                if(fast==3)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
