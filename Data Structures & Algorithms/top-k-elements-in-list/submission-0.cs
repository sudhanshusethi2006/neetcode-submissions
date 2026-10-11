public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
  var dict = nums.GroupBy(x => x).ToDictionary(c => c, c => c.Count());
  var sorted= dict.OrderByDescending(x => x.Value);
  var ans = new int[k];
  int i = k-1;
  foreach(var item in sorted.Take(k))
  {
      ans[i]= item.Key.Key;
      i--;
  }
  return ans;
    }
}
