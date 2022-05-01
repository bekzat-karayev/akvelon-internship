using System;

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
            var uniqueNums = new List<int>();
            uniqueNums.Add(nums[0]);

            for (int index = 1; index < nums.Length; index++)
            {
                if (uniqueNums.Contains(nums[index]))
                {
                    uniqueNums.Remove(nums[index]);
                }
                else
                {
                    uniqueNums.Add(nums[index]);
                }
            }

            return uniqueNums.First();
        }
    }
}
