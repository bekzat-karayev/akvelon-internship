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

        public static int GetNonRepeatedNumber(int[] nums)
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

            foreach (DictionaryEntry pair in numsTable)
            {
                if (pair.Value.ToString() == "1")
                {
                    return (int)pair.Key;
                }
            }

            return nums[0];
        }
    }
}
