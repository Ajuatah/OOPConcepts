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

    public class BaseClass1
    {
        public void SomeMethod()
        {
            // Base class implementation
        }
    }

    public class DerivedClass1 : BaseClass1
    {
        public new void SomeMethod()
        {
            // New implementation in the derived class
        }
    }

        /* It's important to understand the difference between 
        override and new keywords. The override keyword 
        is used to provide a new implementation for a virtual
        or abstract member in the derived class, while the new
        keyword is used to hide a member of the base class with
        a new implementation in the derived class.
        */

}
