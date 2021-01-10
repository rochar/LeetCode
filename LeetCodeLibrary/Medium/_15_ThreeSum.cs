using System;
using System.Collections.Generic;

namespace LeetCodeLibrary.Medium
{
    public class _15_ThreeSum 
    {
        public IList<IList<int>> Execute(int[] nums)
        {
            return ThreeSum(nums);
        }

        public IList<IList<int>> ThreeSum(int[] nums)
        {
            IList<IList<int>> result = new List<IList<int>>(nums.Length / 3);

            Array.Sort(nums);

            var firstPositiveIndex = Array.FindIndex(nums, n => n >= 0);

            int previousI = Int32.MaxValue;
            

            for (var i = 0; i <= firstPositiveIndex; i++)
            {
                if (previousI == nums[i])
                {
                    continue;
                }

                previousI = nums[i];
                int previousJ = Int32.MaxValue;
                for (var j = i + 1; j < nums.Length - 1; j++)
                {
                    if (previousJ == nums[j])
                    {
                        continue;
                    }

                    previousJ = nums[j];
                    var sum = nums[i] + nums[j];

                    if (sum <= 0)
                    {
                        var toFind = -sum;
                        var startAt = j + 1 >= firstPositiveIndex ? j + 1 : firstPositiveIndex;
                        var toFindIndex = Array.BinarySearch(nums, startAt, nums.Length - startAt, toFind);
                        if (toFindIndex >= 0)
                        {
                            var candidate = new[] {nums[i], nums[j], toFind};
                            if (!Contains(result, candidate))
                            {
                                result.Add(candidate);
                            }
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }

            return result;
        }

        public bool Contains(IList<IList<int>> collection, IList<int> item)
        {
            if (collection.Count == 0) return false;

            var lastIndex = collection.Count - 1;
            if (collection[lastIndex][0] == item[0] && collection[lastIndex][1] == item[1] &&
                collection[lastIndex][2] == item[2])
            {
                return true;
            }

            return false;
        }
    }
}