class Solution:
    def isAnagram(self, s: str, t: str) -> bool:
        arr_s=[0] * 26
        arr_t=[0] * 26

        for cs in s:
            arr_s[ord(cs)- ord('a')]+=1
        
        for ct in t:
            arr_t[ord(ct)- ord('a')]+=1

        for i in range(26):
            if arr_s[i]!=arr_t[i]:
                return False

        return True