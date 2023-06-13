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
        public static IEnumerable<int> GetEvenNumbers(int limit)
        {
            for (int i = 0; i < limit; i++)
            {
                yield return i;
            }
        }
        static void Main(string[] args)
        {

           
                foreach (int number in GetEvenNumbers(10))
                {
                    Console.WriteLine(number);
                }
            
            Console.ReadKey();
        }
    }
}
