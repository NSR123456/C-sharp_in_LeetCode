public class Solution {
    public char FindTheDifference(string s, string t) {
        Dictionary<char,int>charSet = new Dictionary<char,int>();

        foreach(char ch in s){
            if(!charSet.ContainsKey(ch)) charSet[ch] = 0;
            charSet[ch]++;
        }
        foreach(char ch in t){
            if(!charSet.ContainsKey(ch)) charSet[ch] =0;
            charSet[ch]--;

            if (charSet[ch] < 0) return ch;
        }
        return '\0';
    }
}
