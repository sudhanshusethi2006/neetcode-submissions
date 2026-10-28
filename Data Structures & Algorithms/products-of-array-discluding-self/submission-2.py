class Solution:
    def productExceptSelf(self, nums: List[int]) -> List[int]:
        left_pre_prod=[0]* len(nums)
        left_pre_prod[0]=1
        for i in range(1,len(nums)):
            left_pre_prod[i]=left_pre_prod[i-1]*nums[i-1]
        right_pre_prod=[0] * len(nums)
        right_pre_prod[len(nums)-1]= 1
        for i in range(len(nums)-2, -1,-1):
            right_pre_prod[i]=right_pre_prod[i+1] * nums[i+1]
        ans=[0]* len(nums)
        for i in range(len(nums)):
            ans[i]= left_pre_prod[i] * right_pre_prod[i]
        return ans            

        