using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.Arrays
{
    /* Given a sorted array A[] of size n, find a element that occurs more than (n/2) times
     * 
     * Example: 
     * 
     * I/P: A[1, 1, 1, 1, 2, 3, 4], n = 7
     * O/P: 1
     * 
    */

    public class MajorityElement
    {
        // Time Complexity : O(n) | Space Complexity : O(1)
        public void FindMajorityElement(int[] ar)
        {
            int count = (ar.Length / 2) + 1;
            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i] == ar[i + (count - 1)])
                {
                    Console.WriteLine($"Majority Element : {ar[i]}");
                    return;
                }
            }
        }

        // Time Complexity : O(n) | Space Complexity : O(1)
        private int IdentifyMajorityElement(int[] ar)
        {
            int majorityIdx = 0;
            int count = 1;
            for (int i = 1; i < ar.Length; i++)
            {
                if (ar[majorityIdx] == ar[i])
                    count++;
                else
                    count--;

                if (count == 0)
                {
                    majorityIdx = i;
                    count = 1;
                }
            }

            return ar[majorityIdx];
        }

        public void FindMajorityElementUsingMooreAlgo(int[] ar)
        {
            int element = IdentifyMajorityElement(ar);
            int count = 0;
            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i] == element)
                    count++;               
            }

            if (count > (ar.Length / 2))
                Console.WriteLine($"Majority Element : {element}");
            else
                Console.WriteLine("No Majority Element in the given array.");
        }
    }
}
