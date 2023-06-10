using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConceptsC_
{
    public class MyResource
    {
        public MyResource()
        {
            Console.WriteLine("Constructor called");
        }

        // Destructor
        ~MyResource()
        {
            Console.WriteLine("Destructor called");
            // Perform cleanup operations here
        }
    }
}
