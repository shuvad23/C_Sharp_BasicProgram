using System;
using System.Numerics;

namespace foreach_keyWord
{
    public class person
    {
        public string[] name;
        public string company_name;
        public  void person1()
        {
            string[] ar_name = { "java", "python", "csharp", "javascript", "kotlin" };
            this.name = ar_name;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            Console.WriteLine("=======================foreach_keyword====================");
            //--------------------using class ----------------------
            var personvar = new person();
            string[] value = { "java", "python", "csharp", "javascript", "kotlin" };
            personvar.person1();
            foreach (string var_name in personvar.name)
            {
                Console.Write($"\n{var_name}");
            }



            //--------------------------------------------------------

            int[] nums = { 2, 3, 4, 5, 6, 6, 7, 8, 9 };
            foreach(int num in nums)
            {
                Console.WriteLine($"\n--------{num + 12}");
            }

            double[] floatvalue = { 2.4, 3.5, 4.6, 5.8, 6.34, 6.75, 7.99, 8.04, 9.95 };
            foreach (int fnum in floatvalue)
            {
                Console.WriteLine($"\n--------{fnum + 12}");
            }

            string[] stValues = { "java", "python", "csharp", "javascript", "kotlin" };
            foreach(string stValue in stValues)
            {
                Console.WriteLine(stValue);
            }
           
            
            Console.ReadLine();
        }
    }
}
