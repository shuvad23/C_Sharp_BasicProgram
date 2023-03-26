using System;

namespace problem_of_array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] arr = new int[] { 4,3,2,1 };
            int k = 1;
            int loc = 1;
            int max = arr[0]; 
            while(k<arr.Length)
            {
                if (k < arr.Length)
                {
                    if (arr[k] < max)
                    {
                        max = arr[k];
                        loc = k;

                    }
                    k = k + 1;
                }
            }
            Console.WriteLine($"{max},{loc}");
            Console.ReadKey();
        }
    }
}
