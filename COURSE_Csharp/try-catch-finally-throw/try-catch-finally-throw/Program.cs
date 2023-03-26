using System;


namespace try_catch_finally_throw
{
    class Program
    {
        static void Main(string[] args)
        {
            //---------------------------------------
            try
            {
                Console.WriteLine("enter the value of Number: ");
                int value = int.Parse(Console.ReadLine());
                Console.WriteLine($" the result is: {value + 12 + 12 + 23}");
            }
            catch (FormatException e)
            {
                Console.WriteLine("this is FormatException");
                // Perform some action here, and then throw a new exception.
                throw new InvalidCastException("Put your error message here.", e);

            }
            catch (InvalidCastException e)
            {
            }
        
            finally
            {
                Console.WriteLine("bye bye------");
            }
            
            }
        }
}
