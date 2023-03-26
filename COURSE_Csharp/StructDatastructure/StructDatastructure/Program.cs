using System;

namespace StructDatastructure
{
    class Program
    {
        struct student
        {
            public string name;
            public string Father_name;
            public string Mother_name;
            public int  roll;
            public int reg;
            public string programming_language;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("---------------Hello World!------------------");
            Console.WriteLine(" ----------use of struct ------------------");
            //------------------------student1--------------------
            student student1;
            Console.Write("Enter the Name of student1: ");
            student1.name = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Enter the student1 Father_name:  ");
            student1.Father_name = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Enter the student1 Mother_name:  ");
            student1.Mother_name = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Enter the student1 Roll number:  ");
            student1.roll = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Enter the student1 Reg number:  ");
            student1.reg = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Enter the programming language which is you favourite: ");
            student1.programming_language = Console.ReadLine();
            Console.WriteLine(student1.name);
            Console.WriteLine(student1.Father_name);
            Console.WriteLine(student1.Mother_name);
            Console.WriteLine(student1.roll);
            Console.WriteLine(student1.reg);
            Console.WriteLine(student1.programming_language);



            //------------student2-------------------
            student student2;
            Console.Write("Enter the Name of student2:  ");
            student2.name = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Enter the student2 Father_name:  ");
            student2.Father_name = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Enter the student2 Mother_name:  ");
            student2.Mother_name = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Enter the student2 Roll number:  ");
            student2.roll = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Enter the student2 Reg number:  ");
            student2.reg = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Enter the programming language which is you favourite: ");
            student2.programming_language = Console.ReadLine();
            Console.WriteLine(student2.name);
            Console.WriteLine(student2.Father_name);
            Console.WriteLine(student2.Mother_name);
            Console.WriteLine(student2.roll);
            Console.WriteLine(student2.reg);
            Console.WriteLine(student2.programming_language);
            Console.ReadLine();
        }
    }
}
