using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace target
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;

            int[] result = TwoSum(nums, target);

            if (result != null)
            {
                Console.WriteLine($"Indices: [{result[0]}, {result[1]}]");
            }
            else
            {
                Console.WriteLine("No solution found.");
            }


        }
        static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> numIndices = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];

                if (numIndices.ContainsKey(complement))
                {
                    return new int[] { numIndices[complement], i };
                }

                if (!numIndices.ContainsKey(nums[i]))
                {
                    numIndices.Add(nums[i], i);
                }
            }


            return null;
        }


    }
}
