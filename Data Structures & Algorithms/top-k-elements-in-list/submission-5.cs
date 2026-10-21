public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
                   var dict = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (!dict.ContainsKey(nums[i]))
                    dict.Add(nums[i], 1);
                else
                    dict[nums[i]]++;
            }

            var bucket = new List<int>[nums.Length+1];
            foreach (var item in dict)
            {
                if (bucket[item.Value] == null)
                    bucket[item.Value] = new List<int>();
                bucket[item.Value].Add(item.Key);
            }

            var ans = new List<int>();

            for (int i = bucket.Length - 1; i >= 0; i--)
            {
                if (bucket[i] == null)
                    continue;

                foreach (int num in bucket[i])
                {
                    ans.Add(num);

                    if (ans.Count == k)
                        return ans.ToArray();
                }
            }
            return ans.ToArray();
}

}