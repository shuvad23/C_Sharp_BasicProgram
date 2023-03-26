using System;

namespace calculater
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("               Hello World!               ");
            Console.WriteLine("==============simple calculater=================");
            Console.WriteLine("Do you want to use this calculater---?????");
            string var1 = Console.ReadLine();
            if("yes"==var1)
            {
                Console.WriteLine("ok starting the process first i verify you-----");
                Console.WriteLine("Do you agree with my condition::?????");
                string var2 = Console.ReadLine();
                if("yes"==var2)
                {
                    Console.WriteLine("ok \nEnter you user ID: ");
                    string userid1 = Console.ReadLine();
                    Console.WriteLine("Enter you Email address: ");
                    string email2 = Console.ReadLine();
                    Console.WriteLine("Enter you Password: ");
                    string password3 = Console.ReadLine();
                    string userid = userid1;
                    string email = email2;
                    string password = password3;
                    if (userid=="shuva9393")
                    {
                        if(email=="shuvad32@gmail.com")
                        {
                            if(password=="pink@#$blue")
                            {
                                Console.WriteLine("---------------------your login sucessfully done----------------------");
                                Console.WriteLine("1.Enter 'open' to start the process---");
                                Console.WriteLine("2.Enter 'close' to stop the process----");
                                Console.WriteLine("3.Enter 'jio' to inpormation about developer---");
                                string numberchoice = Console.ReadLine();
                                switch (numberchoice)
                                {
                                    case "open":
                                        calculaterprocess();
                                        break;
                                    case "close":
                                        break;
                                    case "jio":
                                        jioabout();
                                        break;
                                    default:
                                        Console.WriteLine("your enter value was wrong----");
                                        break;
                                }


                            }
                            else
                            {
                                Console.WriteLine("sorry your password was wrong--please try again....");
                            }
                        }
                        else
                        {
                            Console.WriteLine("sorry your email address was wrong---please try again----");
                        }
                    }
                    else
                    {
                        Console.WriteLine("sorry you user id was wrong---please try again----");

                    }
                    

                }
                else
                {
                    Console.WriteLine("===sorry i can't open calculater without verification=====");
                }

            }
            else
            {
                Console.WriteLine("=======ok bye bye ======");
            }
            Console.ReadLine();
        }

        private static void jioabout()
        {
            Console.WriteLine("==============SD Brand Software Developement Limited=================");
            Console.WriteLine("                        Name : Shuva Das");
            Console.WriteLine("                 Father Name : Sagar Das");
            Console.WriteLine("                 Mother Name : Shati Das");
            Console.WriteLine("        programming language : Python,C#,JavaScript");
            Console.WriteLine("             Contract Number : +8801880946150");
            Console.WriteLine("               Email Address : shuvad31@gmail.com");
            Console.ReadLine();
        }

        private static void calculaterprocess()
        {
            string endprocessing = "";
            while(endprocessing!="exit()")
            {
                Console.WriteLine("1.processing of Addition-----");
                Console.WriteLine("2.processing of Substraction-----");
                Console.WriteLine("3.processing of Multipulation-----");
                Console.WriteLine("4.processing of Division-----");
                Console.WriteLine("5.processing of power-----");
                Console.WriteLine("6.processing of squrt-----");
                Console.WriteLine("7.processing of cordant(using sin and cos)-----");
                Console.WriteLine("8.if you are close the calculater please enter 'close' to stop this process.....");


                int choicevalue = int.Parse(Console.ReadLine());
                switch (choicevalue)
                {
                    case 1:
                        addition();
                        break;
                    case 2:
                        substraction();
                        break;
                    case 3:
                        multipulation();
                        break;
                    case 4:
                        division();
                        break;
                    case 5:
                        power();
                        break;
                    case 6:
                        squrt();
                        break;
                    case 7:
                        sincos();
                        break;
                    case 8:
                        break;
                    default:
                        Console.WriteLine("you do't select any opition...please select any opition which do you want..");
                        break;
                }
                Console.WriteLine("Do you want to quit processing .if Yes(prase 'yes'),if No(prase 'exit()')......thanks for using our calculater------");
                string end = Console.ReadLine();
                if(end=="exit()")
                {
                    endprocessing = end;
                }
                else
                {
                    endprocessing = "";
                }
            }

        }
        private static void sincos()
        {
            Console.WriteLine("enter your choice (sin or cos)------");
            string choicecordent = Console.ReadLine();
            if (choicecordent == "sin")
            {
                Console.WriteLine("================sin=================");
                Console.Write("enter your cordant value: ");
                double sinvalue = double.Parse(Console.ReadLine());
                double result = Math.Sin(sinvalue);

            }
            else if( choicecordent=="cos")
            {
                Console.WriteLine("================cos=================");
                Console.Write("enter your cordant value: ");
                double cosvalue = double.Parse(Console.ReadLine());
                double result = Math.Cos(cosvalue);
            }
            else
            {
                Console.WriteLine("sorry you are not select any one-----");
            }

        }

        private static void squrt()
        {
            Console.WriteLine("enter your squrt value: ");
            int sqrt1 = int.Parse(Console.ReadLine());
            double resutl = Math.Sqrt(Convert.ToDouble(sqrt1));
            Console.WriteLine($"You result squrt of {sqrt1} value is ={resutl}");
            Console.ReadLine();
        }

        private static void power()
        {
            Console.WriteLine("enter your Base value: ");
            int pow1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter your power value: ");
            int pow2 = int.Parse(Console.ReadLine());
            double resutl = Math.Pow(Convert.ToDouble(pow1), Convert.ToDouble(pow2));
            Console.WriteLine($"You result of {pow1} power of {pow2}={resutl}");
            Console.ReadLine();
        }

        private static void division()
        {
            Console.WriteLine("---------------Division-----------------------");
            Console.WriteLine("enter 'add' to output----");
            Console.Write("please enter your first value:");
            int firstvalue = int.Parse(Console.ReadLine());
            Console.WriteLine();
            string quit1 = "";
            int result = firstvalue;
            while (quit1 != "divi")
            {
                Console.WriteLine("Enter the value: ");
                string divi1 = Console.ReadLine();
                if (divi1 == "divi")
                {
                    quit1 = "divi";
                }
                else
                {
                    int value = Convert.ToInt32(divi1);
                    result = result / value;
                }
            }
            Console.WriteLine($"Your total Addition {result}");

        }

        private static void multipulation()
        {
            Console.WriteLine("---------------Multipulation-----------------------");
            Console.WriteLine("enter 'mul' to output----");
            string quit1 = "";
            int result = 1;
            while (quit1 != "mul")
            {
                Console.WriteLine("Enter the value: ");
                string mul1 = Console.ReadLine();
                if (mul1 == "mul")
                {
                    quit1 = "mul";
                }
                else
                {
                    int value = Convert.ToInt32(mul1);
                    result = result * value;
                }
            }
            Console.WriteLine($"Your total Addition {result}");

        }

        private static void substraction()
        {
            Console.WriteLine("---------------Substraction-----------------------");
            Console.WriteLine("enter 'sub' to output----");
            string quit1 = "";
            int result = 0;
            while (quit1 != "sub")
            {
                Console.WriteLine("Enter the value: ");
                string sub1 = Console.ReadLine();
                if (sub1 == "sub")
                {
                    quit1 = "sub";
                }
                else
                {
                    int value = Convert.ToInt32(sub1);
                    result = result - value;
                }
            }
            Console.WriteLine($"Your total Addition {result}");

        }

        private static void addition()
        {
            Console.WriteLine("---------------Addition-----------------------");
            Console.WriteLine("enter 'add' to output----");
            string quit1 = "";
            int result = 0;
            while (quit1 != "add")
            {
                Console.WriteLine("Enter the value: ");
                string add1 = Console.ReadLine();
                if (add1 == "add")
                {
                    quit1 = "add";
                }
                else
                {
                    int value = Convert.ToInt32(add1);
                    result = result + value;
                }
            }
            Console.WriteLine($"Your total Addition {result}");

        }
    }
}
