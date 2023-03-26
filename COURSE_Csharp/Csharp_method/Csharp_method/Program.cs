using System;
using System.Collections.Generic;

namespace Csharp_method
{
    public class refer
    {
        public int referparameter(ref int pinkvalue, ref int pinkvalue1)
        {
            int add = pinkvalue + pinkvalue1;
            return add;
        }

        public void outerparameter(out int outervalue)
        {
            int result = 12;
            outervalue = result;
        }
        public void outerparamter1(out int value1,out int value2)
        {
            Console.Write("enter first value: ");
            value1 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("enter second value: ");
            value2 = int.Parse(Console.ReadLine());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("====================Method====================");

            //---------------------version.cs------------------------------
            var valueshow = new version("Google Play Store","2.4.6",1200000,2002);
            Console.WriteLine(valueshow.appName);
            Console.WriteLine(valueshow.price);
            Console.WriteLine(valueshow.publishyear);



            //-------------------------addition.cs-----------------------------
            var addshow = new addition();
            addshow.sum(2, 3);
            addshow.sum(3, 4, 5);
            addshow.sum(30, 40, 20, 50, 30, 80);



            //------------------------using params----------------------------
            var paramsvalue = new addition();
            paramsvalue.add(new int[] { 3, 3, 3, 3, 4, 4, 23, 5, 9 });
            paramsvalue.add(29, 27, 39, 38, 39, 84);
            paramsvalue.add(29, 27, 2, 4, 65, 23, 53);
            paramsvalue.add(29, 27, 3, 4, 56, 7, 8, 93, 33);
            Console.WriteLine($"total sum: {paramsvalue.add(3, 3, 3, 3, 3)}");


            //--------------------------ref parameter---------------------
            int kvalue=12;
            int kvalue1 = 18;
            var referobj = new refer();
            int result=referobj.referparameter(ref kvalue,ref kvalue1);
            Console.WriteLine(result);



            //------------------------out parameter------------------------
            int outvar;
            referobj.outerparameter(out outvar);
            Console.WriteLine(outvar);
            int avar, bvar;
            referobj.outerparamter1(out avar, out bvar);
            Console.WriteLine($"{avar}, {bvar}");

            Console.ReadLine();
        }
    }
}
