using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.Arrays
{
    /* Find the number occurring odd number of times in an array
     * given that exactly one number occurs odd number of times.
     * 
     * Example: 
     * 
     * I/P: A[2, 3, 1, 2, 3, 1, 1]
     * O/P: 1
     * 
    */
    public class OddOccurrence
    {
        // Time Complexity : O(n) | Space Complexity : O(n)
        public void FindOddOccurrence(int[] ar)
        {
            Dictionary<int, int> valuePairs = new Dictionary<int, int>();

            for (int i = 0; i < ar.Length; i++)
            {
                if (!valuePairs.ContainsKey(ar[i]))
                {
                    valuePairs.Add(ar[i], 1);
                }
                else
                {
                    valuePairs[ar[i]]++;
                }
            }

            var max = valuePairs.Aggregate((l, r) => l.Value > r.Value ? l : r).Key;

            Console.WriteLine($"Number with odd occurrences: {max}");
        }

        // Time Complexity : O(n) | Space Complexity : O(1)
        public void FindOddOccurrenceXOR(int[] ar)
        {
            int max = 0;
            for (int i = 0; i < ar.Length; i++)
            {
                max = ar[i] ^ max;
            }

            Console.WriteLine($"Number with odd occurrences: {max}");
        }
    }
}
