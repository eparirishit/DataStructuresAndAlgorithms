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

            int[] array = new int[] { 1, 4, 3, 3, 5, 2, 6 };
            PairsWithGivenSum pairs = new PairsWithGivenSum();
            pairs.FindPairsForGivenSum(array, 9);

            #endregion

            Console.ReadKey();

        }
    }
}
