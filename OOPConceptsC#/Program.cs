using OOPConceptsC_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConcepts
{
    public  class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "Andropov Ajebua";
            person.Age = 30;
            person.PrintInfo();

            Console.ReadKey();
        }
    }
}
