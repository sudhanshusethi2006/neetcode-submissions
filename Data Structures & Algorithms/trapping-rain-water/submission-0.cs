public class Solution {
    public int Trap(int[] height) {
        var len=height.Length;
        if(len<=1) return 0;
        var leftMax= new int[len];
        var rightMax= new int[len];
        
        leftMax[0]=height[0];
        rightMax[len-1]=height[len-1];
        for(int i=1;i<len;i++)
        {
            leftMax[i]=Math.Max(leftMax[i-1], height[i]);
        }
        for(int i=len-2;i>=0;i--)
        {
            rightMax[i]=Math.Max(rightMax[i+1],height[i]);
        }
        int water=0;

        for(int i=1;i<len-1;i++)
        {
            water+=Math.Min(leftMax[i],rightMax[i])-height[i];
        }
        return water;

    }
}
