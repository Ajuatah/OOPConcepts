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
            MyResource resource = new MyResource();  // Constructor called

            // The object is no longer needed and will be garbage collected at some point

            // Output: Destructor called

            Console.ReadKey();
        }
    }
}
