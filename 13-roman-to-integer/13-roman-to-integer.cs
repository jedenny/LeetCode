public class Solution {
    public int RomanToInt(string s) {
        if(s.Length == 0){
            return 0;
        }
        char firstChar = s[0];
        char secondChar = s.Length > 1 ? s[1] : 'O';
        switch(firstChar){
            case 'I':  
                if(secondChar == 'V'){
                    return 4 + RomanToInt(s.Substring(2));
                }
                else if(secondChar == 'X'){
                    return 9 + RomanToInt(s.Substring(2));
                }
                return 1 + RomanToInt(s.Substring(1));
            case 'V':
                return 5 + RomanToInt(s.Substring(1));
            case 'X':
                if(secondChar == 'L'){
                    return 40 + RomanToInt(s.Substring(2));
                }
                else if(secondChar == 'C'){
                    return 90 + RomanToInt(s.Substring(2));
                }
                return 10 + RomanToInt(s.Substring(1));
            case 'L':
                return 50 + RomanToInt(s.Substring(1));
            case 'C':
                if(secondChar == 'D'){
                    return 400 + RomanToInt(s.Substring(2));
                }
                else if(secondChar == 'M'){
                    return 900 + RomanToInt(s.Substring(2));
                }
                return 100 + RomanToInt(s.Substring(1));
            case 'D':
                return 500 + RomanToInt(s.Substring(1));
            case 'M':
                return 1000 + RomanToInt(s.Substring(1));
            default:
                break;
        }
        return 0;
    }
}