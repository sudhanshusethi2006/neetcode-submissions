public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
            var dict = nums.GroupBy(x => x).ToDictionary(x => x.Key, x => x.ToList().Count);

            return dict.OrderByDescending(x => x.Value).Take(k).Select(c => c.Key).ToArray();
    }
}
