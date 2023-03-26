using System;

namespace lessonproblemarray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int k = 0;
            int[,] name = new int[3,4];
            for (int i=1;i<=3;i++)
            {
                for (int j=1;j<=4;j++)
                {
                    name[i, j] = k++;
                    Console.Write($"{name[i, j]}");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
