#define DEBUG
using System;
namespace Csharp_reference
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("============endif==================");
            int a = 12;
#if DEBUG
            Console.WriteLine("This is currect ");
#endif
            Console.WriteLine("this is wrong");

            Console.ReadLine();
        }
    }
}
