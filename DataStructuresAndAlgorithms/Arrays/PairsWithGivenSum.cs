using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.Arrays
{
    /* Given an array A[], and a number K, find all the pairs (a,b) in A such that [a + b = K]
     * 
     * Example: 
     * 
     * I/P: A[1, 4, 3, 3, 5, 2, 6], K = 9
     * O/P: (4, 5) & (3, 6)
     * 
    */

    public class PairsWithGivenSum
    {
        // Time Complexity : O(n) | Space Complexity : O(n)
        public void FindPairsForGivenSum(int[] ar, int sum)
        {
            HashSet<int> elements = new HashSet<int>();

            for (int i = 0; i < ar.Length; i++)
            {
                int checkElement = sum - ar[i];
                if (checkElement > 0 && elements.Contains(checkElement))
                {
                    Console.WriteLine($"({ar[i]}, {checkElement}) are the pairs with sum {sum}");
                }

                elements.Add(ar[i]); 
            }
        }
    }
}
