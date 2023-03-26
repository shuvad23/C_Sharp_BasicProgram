using System;

namespace Class_and_object
{
    public class person// this is the class 
    {
        public string Name;// this is the field,attribute,or like a variable----
        public string Father_name;
        public void introduse(string next_name)//this is the method -----
        {
            Father_name = "Sagar Das";
            Console.WriteLine($" Hi {Name} {next_name} ,how are you?");
            Console.WriteLine($"{Father_name} your father");
        }
        public static person parse(string str)
        {
            var person1 = new person();
            person1.Name = str;
            return person1;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            /*person object1 = new person();
            object1.Name = "shuva";
            object1.introduse("Das");
            Console.ReadLine();
            */

            //Note static method alowes call by class not object---------
            var value =person.parse("shuva");//not using var we use also person class ---
            value.introduse("Das");
            Console.ReadLine();
        }
    }
}