using System;
using System.Collections.Generic;
using System.Text;

namespace Numeric
{
    class Datatypepower
    {
        public void Maxvalue(string dataname)
        {
           if (dataname=="int")
            {
               int value = int.MaxValue;
                Console.WriteLine(value);
            }
           else if(dataname=="float")
            {
                float value = float.MaxValue;
                Console.WriteLine(value);
            }
            else if (dataname == "decimal")
            {
                decimal value = decimal.MaxValue;
                Console.WriteLine(value);
            }
            else if (dataname == "double")
            {
                double value = double.MaxValue;
                Console.WriteLine(value);
            }
            else if (dataname == "long")
            {
                long value = long.MaxValue;
                Console.WriteLine(value);
            }
            else if (dataname == "byte")
            {
                byte value = byte.MaxValue;
                Console.WriteLine(value);
            }
            else if (dataname == "long")
            {
                sbyte value = sbyte.MaxValue;
                Console.WriteLine(value);
            }
            else if (dataname == "short")
            {
                short value = short.MaxValue;
                Console.WriteLine(value);
            }
        }
        public void Minvalue(string dataname)
        {
            if (dataname == "int")
            {
                int value = int.MinValue;
                Console.WriteLine(value);
            }
            else if (dataname == "float")
            {
                float value = float.MinValue;
                Console.WriteLine(value);
            }
            else if (dataname == "decimal")
            {
                decimal value = decimal.MinValue;
                Console.WriteLine(value);
            }
            else if (dataname == "double")
            {
                double value = double.MinValue;
                Console.WriteLine(value);
            }
            else if (dataname == "long")
            {
                long value = long.MinValue;
                Console.WriteLine(value);
            }
            else if (dataname == "byte")
            {
                byte value = byte.MinValue;
                Console.WriteLine(value);
            }
            else if (dataname == "long")
            {
                sbyte value = sbyte.MinValue;
                Console.WriteLine(value);
            }
            else if (dataname == "short")
            {
                short value = short.MinValue;
                Console.WriteLine(value);
            }
        }
    }
}
