public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
                    int len = nums.Length;
            var prefixProduct = new int[len];
            var suffixProduct = new int[len];

            prefixProduct[0] = 1;
            suffixProduct[len - 1] = 1;

            for (int i = 1; i < len; i++)
            {
                prefixProduct[i] = prefixProduct[i - 1] * nums[i-1];
            }
            for (int i = len - 2; i >= 0; i--)
            {
                suffixProduct[i] = suffixProduct[i + 1] * nums[i+1];
            }
            var products = new int[len];

            //for (int i = 0; i < len; i++)
            //{
            //    products[i] = (prefixProduct[i] * suffixProduct[i]) / nums[i];
            //}
            var ans = new int[len];
            for (int i = 0; i < len; i++)
            {
                ans[i] = prefixProduct[i] * suffixProduct[i];
            }
            return ans;
}
}
