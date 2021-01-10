
namespace LeetCodeLibrary.Easy
{
    public class _1_TwoSum
    {
        public int[] Execute(int[] nums, int target)
        {
            return TwoSum(nums, target);
        }

        public int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (target == nums[i] + nums[j])
                    {
                        return new[] { i, j };
                    }
                }
            }

            return new int[0];

        }
    }
}