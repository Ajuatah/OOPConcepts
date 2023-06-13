using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConceptsC_
{
    public static class Yield
    {
        public static IEnumerable<int> GetEvenNumbers(int limit)
        {
            for (int i = 0; i <= limit; i++)
            {
                if (i % 2 == 0)
                {
                    yield return i; // Yield each even number one at a time
                }
            }
        }


}

    



}
