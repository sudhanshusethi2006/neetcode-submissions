class Solution:

    def encode(self, strs: List[str]) -> str:
        result=[]
        for s in strs:
            result.append(f'{len(s)}#{s}')
        return "".join(result)


    def decode(self, s: str) -> List[str]:
        i=0
        ans=[]
        while(i<len(s)):
            j=i
            while(s[j]!='#'):
                j+=1
            word_len=int(s[i:j])
            ans.append(s[j+1: j+1+ word_len])
            i=j+1+word_len
        return ans
