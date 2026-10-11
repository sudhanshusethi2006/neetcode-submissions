public class Solution {
    public bool IsAnagram(string s, string t) {
           var arr_s = new int[26];
   var arr_t = new int[26];

   for(int i =0;i<s.Length;i++)
   {
       arr_s[s[i] - 'a']++;
   }
   for (int i = 0; i < t.Length; i++)
   {
       arr_t[t[i] - 'a']++;
   }

   for (int i = 0;i<arr_s.Length;i++)
   {
       if (arr_s[i]!=arr_t[i])
           return false;
   }
   return true;
    }
}
