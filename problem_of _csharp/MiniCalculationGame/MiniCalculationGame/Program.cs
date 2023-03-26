using System;

namespace MiniCalculationGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("================Line Massing Game==================");
            Console.WriteLine("Number Limit (1-9) or same value does't count=============");
            Console.Write("Enter you Name: ");
            string username = Console.ReadLine();
            Console.WriteLine();
            if (username == "")
            {
                Console.WriteLine("sorry we can't find any name ...please try again::: ");
            }
            else
            {
                string quitfunction = "";
                while(quitfunction!="exit()")
                {
                    Console.WriteLine($"----------------Hello {username}! welcome to your world-------------");
                    Console.WriteLine("Enter the value of 1st number: ");
                    int x1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the value of 2nd number: ");
                    int x2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the value of 3rd number: ");
                    int x3 = int.Parse(Console.ReadLine());
                    int var1 = x1;
                    int var2 = x2;
                    int var3 = x3;
                    Console.WriteLine("=============================================================");
                    Console.WriteLine("=============================================================");
                    Console.WriteLine("||                 ||                    ||                ||");
                    Console.WriteLine("||                 ||                    ||                ||");
//---------------------------------------------------------------------------------------------------
                    if (var1 < 4)
                    {
                        if (var2 < 4)
                        {
                            if (var3 < 4)
                            {

                                firstblockfunction(var1, var2, var3);
                            }
                            
                                else if (var1 > 0 && var1 < 4)
                                {
                                    if (var2 > 0 && var2 < 4)
                                    {
                                        secondblockfunction(var1, var2);
                                    }
                                }

                        }
                        else if ((var1 > 0 && var1 < 4)&& (var3 > 0 && var3 < 4))
                        {
                            thirdfunction(var1, var3);
                        }

                        else if (var1 == 1)
                            {
                                function1();
                            }

                        
                        else if (var1 == 2)
                        {
                            function2();
                        }

                        else if (var1 == 3)
                        {
                            function3();
                        }

                    }
                    //--------------------------------------------------------------------------------------

                    //------------------

                    //-----------------v2 block-----------------------
                    else if ((var2 > 0 && var2 < 4)&& (var3 > 0 && var3 < 4))
                    {
                        fourtfunction(var1, var3);
                    }
                    else if(var2==1)
                    {
                        function1();
                    }

                    else if (var2 == 2)
                    {
                        function2();
                    }

                    else if (var2 == 3)
                    {
                        function3();
                    }
                    //--------------v3 block----------------------------


                    else if (var3 == 1)
                    {
                        function1();
                    }

                    else if (var3 == 2)
                    {
                        function2();
                    }

                    else if (var3 == 3)
                    {
                        function3();
                    }

                    else
                    {
                        function4();
                    }

                    Console.WriteLine("||                 ||                    ||                ||");
                    Console.WriteLine("||                 ||                    ||                ||");
                    Console.WriteLine("=============================================================");
                    Console.WriteLine("||                 ||                    ||                ||");
                    Console.WriteLine("||                 ||                    ||                ||");
                    if (var1 > 3 && var1 < 7)
                    {
                        if (var2 > 3 && var2 < 7)
                        {
                            if (var3 > 3 && var3 < 7)
                            {

                                firstblockfunction(var1, var2, var3);
                            }
                            else
                            {
                                if (var1 > 3 && var1 < 7)
                                {
                                    if (var2 > 3 && var2 < 7)
                                    {
                                        secondblockfunction(var1, var2);
                                    }
                                }

                            }
                        }
                        else if ((var1 > 3 && var1 < 7)&& (var3 > 3 && var3 < 7))
                        {
                            thirdfunction(var1, var3);
                        }
                        else if (var1 == 4)
                            {
                                function1();
                            }

                        else if (var1 == 5)
                        {
                            function2();
                        }

                        else if (var1 == 6)
                        {
                            function3();
                        }
                    }

                    //----------------v1 block----------------------------


                    //-----------------v2 block----------------------------

                    else if (var2 == 4)
                    {
                        function1();

                    }

                    else if (var2 == 5)
                    {
                        function2();
                    }

                    else if (var2 == 6)
                    {
                        function3();
                    }
                    //-----------v3 block-----------------

                    else if (var3 == 4)
                    {
                        function1();
                    }

                    else if (var3 == 5)
                    {
                        function2();
                    }

                    else if (var3 == 6)
                    {
                        function3();
                    }
                    else
                    {
                        function4();
                    }

                    Console.WriteLine("||                 ||                    ||                ||");
                    Console.WriteLine("||                 ||                    ||                ||");
                    Console.WriteLine("=============================================================");
                    Console.WriteLine("||                 ||                    ||                ||");
                    Console.WriteLine("||                 ||                    ||                ||");
                    //-------------------------------------------------------------------
                    if(var1 > 6 && var1 < 10)
                    {
                        if (var2 > 6 && var2 < 10)
                        {
                            if (var3 > 6 && var3 < 10)
                            {

                                firstblockfunction(var1, var2, var3);
                            }
                            else
                            {
                                if (var1 > 6 && var1 < 10)
                                {
                                    if (var2 > 6 && var2 < 10)
                                    {
                                        secondblockfunction(var1, var2);
                                    }
                                }

                            }
                        }
                        else if ((var1 > 6 && var1 < 10)&& (var3 > 6 && var3 < 10))
                        {
                            thirdfunction(var1, var3);
                        }

                        else if (var1 == 7)
                            {
                                function1();
                            }
                        else if (var1 == 8)
                        {
                            function2();
                        }

                        else if (var1 == 9)
                        {
                            function3();
                        }

                    }
                    //-------------------------------------------------------------------
                    else if ((var2 > 6 && var2 < 10) && (var3 > 6 && var3 < 10))
                    {
                        fourtfunction(var2, var3);
                    }

                    //-------------------v3 block-------------------------


                    //-----------------v2 block----------------------------

                    else if (var2 == 7)
                    {
                        function1();
                    }

                    else if (var2 == 8)
                    {
                        function2();
                    }

                    else if (var2 == 9)
                    {
                        function3();
                    }
                    //-----------v3 block-----------------

                    else if (var3 == 7)
                    {
                        function1();
                    }

                    else if (var3 == 8)
                    {
                        function2();
                    }

                    else if (var3 == 9)
                    {
                        function3();
                    }
                    else
                    {
                        function4();
                    }
                    Console.WriteLine("||                 ||                    ||                ||");
                    Console.WriteLine("||                 ||                    ||                ||");
                    Console.WriteLine("=============================================================");
                    Console.WriteLine("=============================================================");
                    if((var1==1 || var1==2 || var1==3)&& (var2 == 1 || var2 == 2 || var2 == 3)&& (var3 == 1 || var3 == 2 || var3 == 3))
                    {
                        Console.WriteLine("=================%%%%%% You Win the Mach %%%%%%==================");
                    }

                    //-------------------------------------------
                    else if ((var1 == 4 || var1 == 5 || var1 == 6)&& (var2 == 4 || var2 == 5 || var2 == 6)&& (var3 == 4 || var3 == 5 || var3 == 6))
                    {
                        Console.WriteLine("=================%%%%%% You Win the Mach %%%%%%==================");
                    }

                    //--------------------------------------------
                    else if ((var1 == 7 || var1 == 8 || var1 == 9)&& (var2 == 7 || var2 == 8 || var2 == 9)&& (var3 == 7 || var3 == 8 || var3 == 9))
                    {
                        Console.WriteLine("=================%%%%%% You Win the Mach %%%%%%==================");
                    }
                    //------------------------------------------------------
                    else if ((var1 == 1 || var1 == 5 || var1 == 9)&& (var2 == 1 || var2 == 5 || var2 == 9)&& (var3 == 1 || var3 == 5 || var3 == 9))
                    {
                        Console.WriteLine("=================%%%%%% You Win the Mach %%%%%%==================");
                    }
                    //---------------------------------------------------
                    else if ((var1 == 3 || var1 == 5 || var1 == 7)&& (var2 == 3 || var2 == 5 || var2 == 7)&& (var3 == 3 || var3 == 5 || var3 == 7))
                    {
                                Console.WriteLine("=================%%%%%% You Win the Mach %%%%%%==================");
                    }
                    else if ((var1 == 2 || var1 == 5 || var1 == 8) && (var2 == 2 || var2 == 5 || var2 == 8) && (var3 == 2 || var3 == 5 || var3 == 8))
                    {
                                Console.WriteLine("=================%%%%%% You Win the Mach %%%%%%==================");
                    }
                    else if ((var1 == 3 || var1 == 6 || var1 == 9) && (var2 == 3 || var2 == 6 || var2 == 9) && (var3 == 3 || var3 == 6 || var3 == 9))
                    {
                                Console.WriteLine("=================%%%%%% You Win the Mach %%%%%%==================");
                    }
                    else if ((var1 == 1 || var1 == 4 || var1 == 7) && (var2 == 1 || var2 == 4 || var2 == 7)&& (var3 == 1 || var3 == 4 || var3 == 7)) 
                    {
                                Console.WriteLine("=================%%%%%% You Win the Mach %%%%%%==================");
                    }
                    else
                    {
                        Console.WriteLine("=====================^^^^^^^ You lose the Mach ^^^^^==================");
                    }



                    Console.WriteLine("Do you want play the game again?????----if Yes( prase 'yes'),if No(prase 'exit()')");
                    string closevalue = Console.ReadLine();
                    if (closevalue == "yes")
                    {
                        quitfunction = "";
                    }
                    else if (closevalue == "exit()")
                    {
                        quitfunction = "exit()";
                    }
                }
            }

            Console.ReadLine();
        }

        private static void fourtfunction(int var2, int var3)
        {
            string v1 = "*";
            Console.WriteLine($"||         {0}       ||         {v1}          ||         {v1}      ||");

        }

        private static void thirdfunction(int var1, int var3)
        {
            string v1 = "*";
            Console.WriteLine($"||         {v1}       ||         {0}          ||         {v1}      ||");

        }

        private static void function4()
        {
            string v1 = "0";
            Console.WriteLine($"||         {v1}       ||         {v1}          ||         {v1}      ||");

        }

        private static void secondblockfunction(int var1, int var2)
        {
            int[] seconblock = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            if(var1==seconblock[var1] && var2==seconblock[var2])
            {
                string v1 = "*";
                Console.WriteLine($"||         {v1}       ||         {v1}          ||         {0}       ||");

            }
        }

        private static void function3()
        {
            string v1 = "*";
            Console.WriteLine($"||       {0}         ||         {0}          ||        {v1}       ||");

        }

        private static void function2()
        {
            string v1 = "*";
            Console.WriteLine($"||       {0}         ||         {v1}          ||        {0}       ||");

        }

        private static void function1()
        {
            string v1 = "*";
            Console.WriteLine($"||       {v1}         ||         {0}          ||       {0}        ||");
        }

        private static void firstblockfunction(int var1, int var2, int var3)
        {
            int[] firstblock = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            if ((var1 == firstblock[var1] && var2 == firstblock[var2] && var3 == firstblock[var3]))
            {
                
                string v1 = "*";
                Console.WriteLine($"||         {v1}       ||         {v1}          ||         {v1}      ||");
            }
        }
    }
}
