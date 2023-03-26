using System;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            string charatername = "object oriented programming";
            Console.WriteLine("-----string processing ------");
            Console.WriteLine("csharp programming language");
            Console.WriteLine("sharp is a " + charatername + " language");
            Console.WriteLine("he is a good \" programmer");
            Console.Write("hello");
            Console.WriteLine("world");
            //indexing -------------------
            string var1 = "freecodecamp";
            Console.WriteLine(var1[3]);
            
            Console.WriteLine(var1[0]);
            
            Console.WriteLine(var1[4] + "oding properly to be a good programmer");
            
            Console.WriteLine(var1.Length);
            
            Console.WriteLine(var1.IndexOf('c'));
            
            Console.WriteLine(var1.IndexOf("code"));
            //string ----method------------------
            string value = "programcoder";
            string stringvalue = "Great programmer";
            
            Console.WriteLine(value.Length);
            
            Console.WriteLine(value.ToUpper());//convert to uppercase---
           
            Console.WriteLine(value.ToLower());//convert to lowercase---
            
            Console.WriteLine(value.Substring(7));// 7 is the index value and create another string on this position 
            
            string charatervalue = "string is a data type";
            string charatervalue1 = (string)charatervalue.Clone();// this Clone method are used to make a (;) in the string ....

            Console.WriteLine(stringvalue.StartsWith('G'));//start the string 
            Console.WriteLine(stringvalue.StartsWith("Great"));

            char[] ch = { 't' };
            Console.WriteLine(stringvalue.IndexOfAny(ch)+6);

            Console.WriteLine(value.CompareTo(charatervalue));// if comparing was ture he return (0) and false to return (1)...
            

            Console.WriteLine(charatervalue.EndsWith('e'));// this method return boolearn value if the last charater or string was match
            
            Console.WriteLine(charatervalue.EndsWith("type"));
            
            Console.WriteLine(value.Equals(charatervalue));//this method are compare two string and return boolearn value
            
            Console.WriteLine(value.GetHashCode());
            
            Console.WriteLine(charatervalue.GetHashCode());//We know that hash code is an unique id number allocated to an object by JVM(java virtual machine).but this unique number are Garbase(means this value are changed when you refresh the compiler)
            


            string hask = "example dotcom";
            Console.WriteLine(hask.Trim());
            char[] chararr = hask.ToCharArray();// string To chararray convertion------ 
            foreach (char ch in chararr)
            {

                Console.WriteLine(ch);
            }


            Console.WriteLine(value.Contains("program"));//this  method are used if my given string value in there and return boolearn 
            Console.WriteLine(value.Insert(12,".com"));//inserting another string-----
            Console.WriteLine(value.GetType());
            Console.WriteLine(hask.GetTypeCode());
            


            Console.ReadKey();

        }

    }
}
