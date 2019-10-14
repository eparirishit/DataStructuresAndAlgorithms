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

            Console.ReadKey();

        }
    }
}
