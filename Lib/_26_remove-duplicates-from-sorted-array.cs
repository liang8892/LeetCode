using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    public class _26_remove_duplicates_from_sorted_array
    {
        public int RemoveDuplicates(int[] nums)
        {
            for (int i = nums.Length - 1; i - 1 >= 0; i--)
            {
                if (nums[i] == nums[i - 1])
                {
                    DeleteItem(nums, i);
                }
            }

            return nums.Length;
        }

        private void DeleteItem(int[] nums, int index)
        {
            for (int i = index; i + 1 < nums.Length; i++)
            {
                nums[i] = nums[i + 1];
            }
            
        }
    }
}
