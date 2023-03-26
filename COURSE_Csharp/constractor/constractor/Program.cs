using System;
using System.ComponentModel.DataAnnotations;

namespace constractor
{
    class Program
    {
        static void Main(string[] args)
        {
            //--------------------note------------------------------
            // ctrl+tab =to change same window program(means to change .cs file in a same window)----
            //cw+tab=console.writeline()----
            //F9 =to line bug----------------------
            //shift+F5=to break the running program------
            //ctrl+shift+B--------to find any bug in the program or built the program successfully---
            //select class+alt+enter=selected class now a another window tab-----
            // ctrl+x =to remove the line where you use the command

            Console.WriteLine("Hello World!");

            var value2 = new person();
            Console.WriteLine(value2.order);
            var value= new person("shuva",12);// this person is also be a constractor---
            Console.WriteLine($"my name is {value.Name} and your age {value.Age}");
            
            var value1 = new person("sagar");
            Console.WriteLine($"my father name {value1.fatherName}");
            
            
            Console.ReadLine();

        }
    }
}
