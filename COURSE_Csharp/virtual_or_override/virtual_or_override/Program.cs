using System;
using System.Runtime.CompilerServices;

namespace virtual_or_override
{
    //------------------------------------------
    public class books
    {
        
        public virtual int writter(int a,int b)
        {
            return (a + b);
        }
    }
    //---------------------------------------------
    public class book1 : books
    { }
    //--------------------------------------
    public class book2:books
    {
        public override int writter(int a,int b)
        {
            return (a + b) / 2;
        }
    }
    //-----------------------------------------------
    public class car
    {
        protected internal string carname="BMW";
        protected internal string carbrand = "ukap";
        protected internal string name()
        {
            return (this.carname + this.carbrand);
        }
    }
    //------------------------------------------
    class Program
    {
        static void Main(string[] args)
        {
            //--------------------------------
            var boo = new book1();
            Console.WriteLine(boo.writter(12, 12));
            //--------------------------------
            var boo1 = new book2();
            Console.WriteLine(boo1.writter(2, 2));

            var car1 = new car();
            Console.WriteLine(car1.carname);
            Console.WriteLine(car1.carbrand);
            Console.WriteLine(car1.name());
            Console.ReadLine();
        }
    }
}
