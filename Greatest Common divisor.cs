using System;
using System.Text;

public class Solution {
    public string GcdOfStrings(string str1, string str2) {
        string shorter = str1.Length < str2.Length ? str1 : str2;
        
        for(int i = shorter.Length; i>=1; i--)
        {
            string candidate = shorter.Substring(0,i);

            if(Divided(str1, candidate) && Divided(str2, candidate))
            {
                return candidate;
            }
        }
        return "";
    }
    public static bool Divided(string str, string candidate)
    {
        if(str.Length %candidate.Length != 0) return false;

        var sb = new StringBuilder();
        int divideCount = str.Length /candidate.Length;
        for(int i=0;i<divideCount;i++)
        {
            sb.Append(candidate);
        }
        return sb.ToString() == str;

    }
}