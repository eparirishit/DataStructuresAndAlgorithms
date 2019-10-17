using DataStructuresAndAlgorithms.Arrays;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            #region PairsWithGivenSum

            int[] arr1 = new int[] { 1, 4, 3, 3, 5, 2, 6 };
            PairsWithGivenSum pairs = new PairsWithGivenSum();
            pairs.FindPairsForGivenSum(arr1, 9);

            #endregion

            #region MajorityElement

            int[] arr2 = new int[] { 1, 1, 1, 2, 2, 2, 2 };
            MajorityElement element = new MajorityElement();
            element.FindMajorityElement(arr2);
            element.FindMajorityElementUsingMooreAlgo(arr2);

            #endregion

            #region MaxDifference

            int[] arr3 = new int[] { 3, 1, 4, 7, 5, 100, 10 };
            MaxDifference difference = new MaxDifference();
            difference.FindMaxApproachOne(arr3);
            difference.FindMaxApproachTwo(arr3);

            #endregion

            #region OddOccurrence

            int[] arr4 = new int[] { 2, 3, 1, 2, 3, 1, 1 };
            OddOccurrence occurrence = new OddOccurrence();
            occurrence.FindOddOccurrence(arr4);
            occurrence.FindOddOccurrenceXOR(arr4);

            #endregion

            Console.ReadKey();

        }
    }
}
