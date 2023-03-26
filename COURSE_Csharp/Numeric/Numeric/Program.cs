using System;

namespace Numeric
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");
            int value = 12;
            Console.WriteLine(value);
            Console.WriteLine(value.ToString()+" pink");
            Console.WriteLine(value.CompareTo(12));
            Console.WriteLine(value.Equals(32));
            Console.WriteLine(value.GetHashCode());
            Console.WriteLine(value.GetType());
            int max = int.MaxValue;// this is the max value of int type data----------
            Console.WriteLine($"Maxvalue of INT type data:{max}");
            int min = int.MinValue;// this is the min value of int type data----------
            Console.WriteLine($"Minvalue of INT type data:{min}");
            //--------------------------------
            double doublevalue = Convert.ToDouble(value);
            sbyte sbytevalue = Convert.ToSByte(value);
            byte bytevalue = Convert.ToByte(value);
            long longvalue = Convert.ToInt64(value);
            long longvalue1 = Convert.ToInt32(value);

            //--------------------------------------
            Console.WriteLine($"doublevalue==={doublevalue}\n bytevalue=={bytevalue}\n sbytevalue=={sbytevalue}\nlongvalue=={longvalue}\nlongblue1=={longvalue1} ");
            Console.WriteLine(value + 12 + 12);
            Console.WriteLine(value++);
            //--------------------------Double--------------------------------
            double value2 = 12.42;
            Console.WriteLine(value2);
            double maxvalue = double.MaxValue;
            Console.WriteLine($"Maxvalue of double type data:{maxvalue}");
            double minvalue = double.MinValue;
            Console.WriteLine(minvalue);
            //-----------------------byte-------------------------------------
            byte value3 = 111;
            Console.WriteLine(value3);
            Console.WriteLine(Convert.ToInt32(value3));
            byte maxvalue2 = byte.MaxValue;
            Console.WriteLine($"Maxvalue of byte type data:{maxvalue2}");
            byte minvalue2 = byte.MinValue;
            Console.WriteLine(minvalue);
            //----------------long data type---------------------
            long value4 = 1239893993;
            long maxvalueof_long = long.MaxValue;
            Console.WriteLine($"Maxvalue of long type data:{maxvalueof_long}");
            long minvalueof_long = long.MinValue;
            Console.WriteLine(minvalueof_long);
            Console.Beep();

            decimal value5 = 12;
            decimal decimaloffloatvalue = 23.34M;
            Console.WriteLine(value5 + decimaloffloatvalue);
            decimal  MaxofDecimal = decimal.MinValue;
            Console.WriteLine($"Maxvalue of INT type data:{MaxofDecimal}");
            Console.WriteLine(decimal.MinValue);






            //------------converter to find the Maxvalue of each datatype---------
            Datatypepower converter = new Datatypepower();
            Console.WriteLine("Which data type do you find the maxvalue: ");
            string pink = Console.ReadLine();
            converter.Maxvalue(pink);
            //------------------------------------------------------------


            //-----------------Numeric processing -----------------------
            int number1 = 12;
            int number2 = 25;
            Console.WriteLine(number1 + number2);
            Console.WriteLine(Convert.ToInt32(number1) + Convert.ToDecimal(number2));
            Console.WriteLine(Convert.ToDouble(number1 + number2));
            Console.WriteLine(Convert.ToByte(number2) + Convert.ToSByte(number1));
            Console.WriteLine(Convert.ToInt64(number2+22222222));


            double num1 = 12.22;
            double num2 = 23.45;
            Console.WriteLine(num1 + num2);
            Console.WriteLine(Convert.ToDecimal(num1) + Convert.ToDecimal(num2));



            int a = 12;
            double b = 12.23;
            float c = 12.23F;
            decimal d = 23.23M;
            decimal e = 23;
            Int64 var = 1111111;
            Int16 var1 = 23443;
            Int32 var2 = 123333;
            long var3 = 2323232323;
        }
    }
}