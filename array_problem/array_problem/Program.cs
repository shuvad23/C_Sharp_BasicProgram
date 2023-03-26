using System;

namespace array_problem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello world");
            int[] arr = new int[5];
            for(int i=1;i<3;i++)
            {
                Console.WriteLine("enter value: ");
                int val = int.Parse(Console.ReadLine());
                arr[i] = val;
            }
            Console.WriteLine(arr[1]);
            Console.ReadLine();
        }
    }
}
