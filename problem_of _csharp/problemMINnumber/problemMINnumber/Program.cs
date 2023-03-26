using System;

namespace problemMINnumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 45,3,4,5,6,7,8,22,32,11,10,23,42,9};
            int j;
            int b=0;
            int max = arr[0];
            for (j = 1; j < arr.Length; j++)
            {
                if (arr[j] > max)
                {
                    max = arr[j];
                    b = j;
                }
           
            }
            Console.WriteLine($"value{max},and the location {b+1}");
            Console.ReadKey();
        }
    }
}
