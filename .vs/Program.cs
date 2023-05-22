using System;
using System.Collections.Generic;

public class LongestSubstring
{
    public static void Main(String[] args)
    {
        string s = "abcabcbb";
        int length = LengthOfLongestSubstring(s);
        Console.WriteLine(length);
    }

    public static int LengthOfLongestSubstring(string s)
    {
        int n = s.Length; //length of the string
        if (n == 0) return 0; //if string is empty, return 0
        Dictionary<char, int> map = new Dictionary<char, int>();
        //A dictionary for saving indizes of the symbols in the string
        int maxLen = 0;
        //length of the longest substring
        for (int i = 0, j = 0; i < n; i++)
        {
            if (map.ContainsKey(s[i])) j = Math.Max(j, map[s[i]] + 1); //h
            map[s[i]] = i;
            maxLen = Math.Max(maxLen, i - j + 1);
        } //run through the string from left to the right
        return maxLen;
    }
}
