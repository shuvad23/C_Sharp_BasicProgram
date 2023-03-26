using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace operator_overloading
{
    class Program
    {
        int feet, inch;
        public Program()
        {
            this.feet = 0;
            this.inch = 0;
        }
        public Program(int feet,int inch)
        {
            this.feet = feet;
            this.inch = inch;
        }
        public static Program operator +(Program len1,Program len2)
        {
            Program len3 = new Program();
            len3.feet = len1.feet + len2.feet;
            len3.inch = len1.inch + len2.inch;
            if(len3.inch>=12)
            {
                len3.feet++;
                len3.inch -= 12;
            }
            return len3;
        }
        string Getprogram()
        {
            return string.Format("result {0}' {1}\"", feet, inch);
        }
        static void Main(string[] args)
        {
            Program obj1 = new Program(12,2);
            Program obj2 = new Program(4, 14);
            Program obj3 = obj1 + obj2;
            Console.WriteLine(obj1.Getprogram());
            Console.WriteLine(obj2.Getprogram());
            Console.WriteLine(obj3.Getprogram());
        }
    }
}
