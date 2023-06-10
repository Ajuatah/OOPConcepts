using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConceptsC_
{
    internal class PrivateConstructor
    {
    }

    public class Singleton
    {
        private static Singleton instance;

        // Private constructor
        private Singleton()
        {
            // Initialization code
        }

        // Public static method to access the single instance
        public static Singleton GetInstance()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }

        // Other methods and properties of the Singleton class
        public void DoSomething()
        {
            // Perform some action
        }
    }
}
