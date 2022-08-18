public class Solution {
    private string[] map = new string[26]{".-","-...","-.-.","-..",".","..-.","--.","....","..",".---","-.-",".-..","--","-.","---",".--.","--.-",".-.","...","-","..-","...-",".--","-..-","-.--","--.."};
    
    public int UniqueMorseRepresentations(string[] words) {
        HashSet<string> mappings = new HashSet<string>();
        
        foreach(var word in words){
            string morse = "";
            foreach(var character in word){
                morse+=map[character-'a'];
            }
            mappings.Add(morse);
        }
        return mappings.Count();
    }
}