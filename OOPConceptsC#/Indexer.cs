using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConceptsC_
{
    internal class Indexer
    {
    }

    public class MyCollection
    {
        private string[] data = new string[10];

        // Indexer declaration
        public string this[int index]
        {
            get
            {
                return data[index];
            }
            set
            {
                data[index] = value;
            }
        }
    }

    public class StringCollection
    {
        private string[] data = new string[10];

        public string this[int index]
        {
            get
            {
                return data[index];
            }
            set
            {
                data[index] = value;
            }
        }
    }

}
