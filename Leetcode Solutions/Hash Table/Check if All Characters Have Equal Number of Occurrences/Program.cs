using System;
using System.Collections.Generic;

// Given a string s, return true if s is a good string, or false otherwise.
// A string s is good if all the characters that appear in s have the same number of occurrences (i.e., the same frequency).
namespace _1941._Check_if_All_Characters_Have_Equal_Number_of_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "abacbc";     
            Boolean flag = true;       
            Dictionary <char, int> dict = new Dictionary <char, int>();
            
            for(int i = 0; i <= s.Length-1; i++) {
                if(!dict.ContainsKey(s[i]))
                    dict.Add(s[i], 0);

                dict[s[i]]++;
            }
            
            for(int i = 1; i < dict.Count; i++) {
                if(dict.ElementAt(i-1).Value != dict.ElementAt(i).Value)
                    flag = false;         
            }
            
            Console.WriteLine(flag);
            
        }
    }
}
