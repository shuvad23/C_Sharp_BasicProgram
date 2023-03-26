using System;

namespace problem4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("enter the value of number:");
            int num = int.Parse(Console.ReadLine());
            for(int i=1;i<=num;i++)
            {
                int last = i % 10;
                if(last==3)
                {
                    int fast = 0;
                    int n = i / 10;
                    while(n>0)
                    {
                        fast = n;
                        n = n / 10;

                    }
                    if(fast==last)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
