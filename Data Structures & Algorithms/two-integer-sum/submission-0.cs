public class Solution {
    public int[] TwoSum(int[] nums, int target) {
                    var dict = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                var dif = target - nums[i];

                if(dict.ContainsKey(dif))
                {
                    return new int[] { dict[dif],i }; 
                }
                dict.Add(nums[i], i);
            }
            return new int[] { };
        }
    }

