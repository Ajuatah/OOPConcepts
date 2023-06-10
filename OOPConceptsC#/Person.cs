using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConceptsC_
{
    public   class Person
    {
        private string name;
        private int age;

        public string Name { 
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }

        }

        public void PrintInfo()
        {
            Console.WriteLine($"Your Name is {Name} with {Age}");
        }
        
    }
}
