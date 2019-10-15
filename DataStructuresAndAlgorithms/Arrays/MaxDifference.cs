using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.Arrays
{
    /* Find the maximum difference between two elements in an array such that
     * larger element appears after the smaller number.
     * 
     * Example: 
     * 
     * I/P: A[4, 3, 10, 2, 9, 1, 6]
     * O/P: 7
     * 
    */

    public class MaxDifference
    {
        // Time Complexity : O(n) | Space Complexity : O(n)
        public void FindMaxApproachOne(int[] ar)
        {
            int size = ar.Length - 1;
            int[] diffArray = new int[size];

            for (int i = 0; i < size - 1; i++)
            {
                diffArray[i] = ar[i + 1] - ar[i];
            }

            int currentMax = diffArray[0];

            for (int i = 1; i < size; i++)
            {
                if (diffArray[i - 1] > 0)
                {
                    diffArray[i] = diffArray[i] + diffArray[i - 1];
                }
                currentMax = Math.Max(currentMax, diffArray[i]);
            }

            Console.WriteLine($"Maximum difference : {currentMax}");
        }

        // Time Complexity : O(n) | Space Complexity : O(1)
        public void FindMaxApproachTwo(int[] ar)
        {
            int currentMin = ar[0];
            int currentMax = ar[1] - ar[0];
            int differenceMax = ar[1] - ar[0];

            for (int i = 1; i < ar.Length; i++)
            {
                if (ar[i] < currentMin)
                    currentMin = ar[i];
                else
                {
                    currentMax = ar[i] - currentMin;
                    if (currentMax > differenceMax)
                        differenceMax = currentMax;
                }
            }

            Console.WriteLine($"Maximum difference : {differenceMax}");
        }
    }
}
