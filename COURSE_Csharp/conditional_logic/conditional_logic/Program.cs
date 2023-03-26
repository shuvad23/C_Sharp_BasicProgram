using System;

namespace conditional_logic
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Hello World!");
            Console.WriteLine("---------------conditional logic----------------");
            Console.WriteLine("enter two string :   ");
            //----------------if-else-----------------------------
            string stringvalue1 = Console.ReadLine();
            string stringvalue2 = Console.ReadLine();
            bool boolvalue1 = true;
            if(stringvalue1==stringvalue2)
            {
                Console.WriteLine(boolvalue1);
            }
            else
            {
                Console.WriteLine(false);
            }
            
            //-------------------if-else if-else-----------
            Console.WriteLine("enter enter two number: ");
            int var = int.Parse(Console.ReadLine());
            int var1 = int.Parse(Console.ReadLine());
            if (var==var1)
            {
                Console.WriteLine("equals-------------");
            }
            else if(var>var1)
            {
                Console.WriteLine("var is greater then var1");
            }
            else if (var < var1)
            {
                Console.WriteLine("var is lese then var1");
            }
            else if (var >= var1)
            {
                Console.WriteLine("var is greater  then equals to var1");
            }
            else if (var <= var1)
            {
                Console.WriteLine("var is lese then equals to  var1");
            }
            else if (var!= var1)
            {
                Console.WriteLine("var is not equals to var1");
            }
            else
            {
                Console.WriteLine("the condition is  not right.....");
            }
            */

            //-----------------nested if------------------
            /*
            Console.WriteLine("----------------Nested if----------------");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());
            if (a == b || a < c || a > d || (Math.Abs(a) == c) || (e == a))
            {
                if (a != b)
                {
                    if (b != c)
                    {
                        if (c != d)
                        {
                            if (c != b && b != e)
                            {
                                if (true)
                                {
                                    Console.WriteLine("hello welcome");
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine("Nested if -else------------------");

            //----------------------nested if-else-----------------------
            if(a==b)
            {
                if(b==c)
                {
                    if(c==d)
                    {
                        if (d == e)
                        {
                            Console.WriteLine("hello");
                        }
                        else
                        {
                            Console.WriteLine("sorry");
                        }
                    }
                    else
                    {
                        Console.WriteLine("sorry1");
                    }

                }
                else
                {
                    Console.WriteLine("sorry2");
                }
            }
            else
            {
                Console.WriteLine("sorry3");
            }


            //--------------------------------nested if -else if-else----------------
            if(a==b)
            {
                if (b != c)
                {
                    Console.WriteLine("hello world");
                }
                else if (b <a)
                {
                    Console.WriteLine("hello python");
                }
                else if (b == a)
                {
                    Console.WriteLine("hello python");
                }
                else if (b == d)
                {
                    Console.WriteLine("hello python");
                }
                else
                {
                    Console.WriteLine("hello pink");
                }
            }
            else if (b == c)
            {
                Console.WriteLine("hello python");
            }
            else if (b == d)
            {
                Console.WriteLine("hello python");
            }
            else if (b == e)
            {
                Console.WriteLine("hello python");
            }
            else
            {
                Console.WriteLine("hello c# programmer------------------");
            }


            //--------------------nested else-----------------
            if(a!=b)
            {
                Console.WriteLine("hello world");
            }
            else
            {
                if(a==b)
                {
                    Console.WriteLine("hello world");
                }
                else
                {
                    if(b==d)
                    {
                        Console.WriteLine("hello world");
                    }
                    else
                    {
                        if(b<=e)
                        {
                            Console.WriteLine("hello world");
                        }
                        else
                        {
                            if(a.Equals(b))
                            {
                                Console.WriteLine("hello world");
                            }
                            else
                            {
                                Console.WriteLine("bye bye-----");
                            }
                        }
                    }
                }
            }

            */

            //-------------------conditional operator---------------


            int var1 = 12;
            int var2 = 12;
            int var3 = 23;
            bool value;
            //
            value=(var1 == var2)? true : false;
            Console.WriteLine(value);

            string  value2 = (var1 < var2) ? "this is correct program" : (var1 < var3) ? "this is also correct program": "this is not correct";
            Console.WriteLine(value2);


            string string_value = "joy";
            string string_value2 = "joy";
            string string_value3 = "roy";
            string result = (string_value != string_value2) ? "right" : (string_value2 == string_value3) ? "hello" : (string_value == "pink") ? "hello python" : (string_value == string_value2) ? "yes this is correct one----" : "sorry";
            Console.WriteLine(result);
        }
    }
}
