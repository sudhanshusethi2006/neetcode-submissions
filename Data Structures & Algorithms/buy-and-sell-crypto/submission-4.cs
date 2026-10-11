public class Solution {
    public int MaxProfit(int[] prices) {
        int i=0;
        int j=1;
        int profit=0;
        while(j<prices.Count())
        {
            int temp= prices[j]-prices[i];
            profit= Math.Max(profit, temp);
            if(temp<=0)
            {
                i=j;
            }

            j++;
        }

        return profit;
    }
}
