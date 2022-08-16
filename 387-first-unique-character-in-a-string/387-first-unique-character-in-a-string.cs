public class Solution {
    // Second attempt - process the string O(n), then O(26), therefor O(n)
    public int FirstUniqChar(string s) {
        int lowercaseOffset = 'a';
        
        Dictionary<char, int> currentlyUnique = new Dictionary<char,int>();
        
        for(int i = 0; i < s.Length; i ++)
        {
            if(currentlyUnique.ContainsKey(s[i]))
            {
                currentlyUnique.Remove(s[i]);
                currentlyUnique.Add(s[i], -1);
            }
            else
            {
                currentlyUnique.Add(s[i], i);
            }
            
        }
        if(currentlyUnique.Count() == 0) return -1;
        
        var earliestIndex = s.Length;
        foreach( KeyValuePair<char, int> kvp in currentlyUnique)
        {
            earliestIndex = kvp.Value != -1 && kvp.Value < earliestIndex ? kvp.Value : earliestIndex;
        }
        return earliestIndex == s.Length ? -1 : earliestIndex;
    }
    
    // First naive approach: O(n^2)
    public int FirstUniqCharNaive(string s) {
        // Start With the naive approach: O(n^2)
        for(int i = 0; i < s.Length; i++)
        {
            char curChar = s[i];
            bool duplicateFound = false;
            for(int j = 0; j < s.Length; j++)
            {
                if(i!=j && s[i] == s[j])
                {
                    duplicateFound = true;
                }
            }
            if(!duplicateFound) return i;
        }
        return -1;
    }
    
}