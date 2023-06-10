using OOPConceptsC_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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

            // indexer
            MyCollection collection = new MyCollection();

            // Using the indexer to get/set values
            collection[0] = "Value 1";
            string value = collection[0];

            Console.WriteLine("Value at index 0: " + value);  // Output: Value 1

            StringCollection collection1 = new StringCollection();

            collection1[0] = "First";
            collection1[1] = "Second";

            Console.WriteLine(collection1[0]);  // Output: "First"
            Console.WriteLine(collection1[1]);  // Output: "Second"

            //even
            Button button = new Button();

            // Subscribing to the event using an event handler
            button.Click += Button_Click;

            // Raising the event
            button.OnClick();
            

            Console.ReadKey();
        }

        // Event handler method
        static void Button_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Button clicked!");
        }


    }
}
