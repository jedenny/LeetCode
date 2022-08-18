public class Solution {
    
    public int MinSetSize(int[] arr) 
    {
        int halfLength = arr.Count()/2; // optimize by dividing once
        
        // Sort the arr in decreasing order via LINQ
        var dictDescByCount = arr.GroupBy(c => c).OrderByDescending(c => c.Count()).ToArray();
        
        int curTotal = 0;
        int curSetSize = 0;
        foreach(var i in dictDescByCount){
            curSetSize++;
            curTotal+=i.Count();
            if(curTotal >= halfLength){
                return curSetSize;
            }
        }
        return 0;
    }
    
    
}