using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Two_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] {2, 7, 11, 12};
            int[] result = Solution.TwoSum(nums, 9);
            if (result != null)
            {
                Console.WriteLine("成功：[{0},{1}]", result[0], result[1]);
            }
            Console.ReadKey();
        }
    }

    public class Solution
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                        return new[] {i, j};
                }
            }
            return null;

            //if (nums.Length == 2 && nums.Sum() == target)
            //    return new int[] { 0, 1 };
            //if (nums.Length > 2)
            //{
            //    for (int i = 0; i < nums.Length; i++)
            //    {
            //        int a = nums[i];
            //        int b = target - a;
            //        if (nums.Contains(b))
            //        {
            //            int c = Array.IndexOf(nums, b, i + 1);
            //            if (c != -1)
            //                return new[] { i, c };
            //        }
            //    }
            //    return null;
            //}
            //else
            //{
            //    return null;
            //}

        }
    }
}
