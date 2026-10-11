public class Solution {
    public bool hasDuplicate(int[] nums) {
             var dict = nums.GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());


            return dict.Any(x => x.Value > 1);

    }
}