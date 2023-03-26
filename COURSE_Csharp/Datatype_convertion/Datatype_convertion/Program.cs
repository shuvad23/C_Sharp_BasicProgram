using System;
using System.Runtime.InteropServices;

namespace Datatype_convertion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=============type convertion================");
            Console.WriteLine("-----------implict convertion----------------");
            // lower to upper------
            byte number1 = 23;
            int number2 = number1;
            Console.WriteLine(number2);
            


            int value1 = 4040;
            float value2 = value1;
            Console.WriteLine(value2);


            float flvalue = 202.34f;
            double flvalue1 = flvalue;
            Console.WriteLine(flvalue1);

            Console.WriteLine("===================Explict convertion=================");
            //upper to lower convertion
            double eValue = 2929.383;
            int evalue1 =(int)eValue;
            Console.WriteLine(evalue1);

            int iValue = 3456;
            byte ivalue1 = (byte)iValue;
            Console.WriteLine(ivalue1);

            Console.WriteLine("====================non-compatible convertion=============");

            string non_value = "23456";
            int non_value1 = Convert.ToInt32(non_value);


            float floatvalue = 3333.33f;
            byte floatvalue1 = Convert.ToByte(floatvalue);
            Console.ReadLine();
        }
    }
}
