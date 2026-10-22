class Solution:
    def topKFrequent(self, nums: List[int], k: int) -> List[int]:
        dict={}
        
        for num in nums:
            if num in dict:
                dict[num] +=1
            else:
                dict[num]=1
        
        bucket=[]

        for i in range(len(nums)+1):
            bucket.append([])
        
        for n in dict:
            bucket[dict[n]].append(n)
        
        ans=[]


        for i in range(len(bucket) - 1, 0, -1):
            for n in bucket[i]:
                ans.append(n)
                k -= 1
                if k == 0:
                    return ans
        
        return ans
        