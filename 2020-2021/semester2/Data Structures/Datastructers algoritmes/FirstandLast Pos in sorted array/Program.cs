using System;

namespace FirstandLast_Pos_in_sorted_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = { 2, 3, 3, 5, 5, 5, 5, 6, 8, 8, 8, 10, 12, 14 };
            int target = 5;
        }

        private int extremeInsertionIndex(int[] nums, int target, bool left)
        {
            int lo = 0;
            int hi = nums.Length;
            while (lo < hi)
            {
                int mid = (lo + hi) / 2;
                if (nums[mid] > target || (left && target == nums[mid]))
                {
                    hi = mid;
                }
                else
                {
                    lo = mid + 1;
                }
            }
            return lo;
        }
        public int[] searchRange(int[] nums, int target)
        {
            int[] targetRange = { -1, -1 };
            int leftIdx = extremeInsertionIndex(nums, target, true);
            if (leftIdx == nums.Length || nums[leftIdx] != target)
            {
                return targetRange;
            }
            targetRange[0] = leftIdx;
            targetRange[1] = extremeInsertionIndex(nums, target, false) - 1;
            return targetRange;
        }
    }
}
