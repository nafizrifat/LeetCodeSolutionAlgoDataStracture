using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutionAlgoDataStracture
{
    class _039CombinationSum
    {
        public _039CombinationSum()
        {
            CombinationSum(new int[] {2, 3, 6, 7}, 7);
        }
        public IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            Array.Sort(candidates);

            IList<IList<int>> results = new List<IList<int>>();
            IList<int> nums = new List<int>();

            Helper(candidates, 0, 0, new List<int>(), results, target);
            return results;
        }

        private void Helper(int[] candidates, int index, int sum, IList<int> nums, IList<IList<int>> results,
            int target)
        {
            if (index < candidates.Length)
            {
                int temp = candidates[index] + sum;
                if (temp > target)
                {

                }
                else if (temp == target)
                {
                    nums.Add(candidates[index]);
                    results.Add(nums.ToList());
                    nums.RemoveAt(nums.Count - 1);
                }
                else
                {
                    nums.Add(candidates[index]);
                    Helper(candidates, index, temp, nums, results, target);
                    nums.RemoveAt(nums.Count - 1);

                    Helper(candidates, index + 1, sum, nums, results, target);
                }
            }
        }
    }

}
