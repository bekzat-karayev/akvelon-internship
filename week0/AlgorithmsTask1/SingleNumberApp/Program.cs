using System;
using System.Collections;

namespace SingleNumberApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            throw new NotImplementedException();
        }

        // The idea of solution is pretty simple
        // A hashtable is generated from given array of integers,
        // where hashtable keys are elements of tha array and
        // values are number of occurrence of these elements inside the array
        // e.g. Array [1, 5, 1] produces hashtable {[1, "2"], [5, "1"]}
        // After that this hashtable is traversed, until a value "1" is found, 
        // and then its key is returned as a final result.
        // Which means that the element of the initial array that occurs in the array
        // only once is fouund.

        // ContainsKey method is performed in O(1) time, single iteration through array 
        // and hashtable is done in O(n) time, 
        // therefore this algorithm has linear time complexity
        // and uses additional memory not more than size of the input array 

        public static int GetNonRepeatedNumber(int[] nums)
        {
            var table = CreateHashtable(nums);
            return LookupValueOne(table);
        }

        public static Hashtable CreateHashtable(int[] nums)
        {
            var numsTable = new Hashtable();
            for (int index = 0; index < nums.Length; index++)
            {
                if (!numsTable.ContainsKey(nums[index]))
                {
                    numsTable.Add(nums[index], "1");
                }
                else
                {
                    numsTable[nums[index]] = "2";
                }
            }

            return numsTable;
        }

        public static int LookupValueOne(Hashtable table)
        {
            foreach (DictionaryEntry pair in table)
            {
                if (pair.Value.ToString() == "1")
                {
                    return (int)pair.Key;
                }
            }

            return 0;
        }
    }
}
