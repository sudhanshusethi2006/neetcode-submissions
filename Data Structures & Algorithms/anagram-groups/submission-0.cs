public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
                  var dict = new Dictionary<string, List<string>>();

          foreach (string str in strs)
          {


              var chars = str.ToCharArray();
              Array.Sort(chars);
              var sortedWord = new string(chars);
              if (!dict.ContainsKey(sortedWord))
                  dict.Add(sortedWord, new List<string>());
              dict[sortedWord].Add(str);

          }
          return dict.Values.ToList();
    }
}
