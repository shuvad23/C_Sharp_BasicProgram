
using System.Collections.Generic;

namespace constractor
{
    public class person
    {
        public string Name;
        public int Age;
        public string fatherName;
        public List<order> order;
        // without parameter constractor ---also parameter less constractor--------
        public person()
        {
            this.order =new List<order>();
        }

        //with parameter constracotr  ----also call constractor overloading-----
        public person(string father)//write (ctor)+tab for create------------------- 
            :this()
        {
            this.fatherName = father;
        }
        //with parameter constracotr -----also call constractor overloading-----
        public person(string name,int age)// person is a constractor because a constractor was create when the class represent---
            :this()
        
        {
            this.Name = name;
            this.Age = age;
        }

        
    }
}
