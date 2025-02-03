using System;
using System.Linq;
using System.Collections.Generic;

// Given two strings s and goal, return true if you can swap two letters in s so the result is equal to goal, otherwise, return false.
// Swapping letters is defined as taking two indices i and j (0-indexed) such that i != j and swapping the characters at s[i] and s[j].
// For example, swapping at indices 0 and 2 in "abcd" results in "cbad".
// Runtime: 80 ms, faster than 51.34% of C# online submissions for Buddy Strings.
// Memory Usage: 23.8 MB, less than 43.32% of C# online submissions for Buddy Strings.
namespace Buddy_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string s= "abcd", goal= "abbb"; // s= "ab", goal = "ba"; 
            // s = "abcaa", goal = "abcbb"; // s = "aaaaaaabc", goal = "aaaaaaacb";  
            int matchedChar = 0;
            bool flag = false;
            List<int> diff = new List<int>();
            HashSet<char> hs = new HashSet<char>();

            Console.WriteLine("s= " + s + ", goal= " + goal);

            if(s.Length == 1 || s.Length != goal.Length)  // check lengths of both strings are the same
            {
                flag = false;
            }
            else if(s == goal)
            {  
                var c = new HashSet<char>(s).Count();
                flag = (c != s.Length) ? true : false;    // does the string contain any duplicate characters that could be swapped
               
            }
            else
            {
                for(int i = 0; i <= s.Length-1; i++) 
                {
                    if(s[i] != goal[i]) // check if possible to perform at least one string swap
                    {
                        diff.Add(i);  // save index to list
                        matchedChar++;
                    }                                  
                }

                flag =  (matchedChar == 2 && s[diff[0]] == goal[diff[1]] && goal[diff[0]] == s[diff[1]]) ? true : false; // verify matched characters

            }            
                    
            Console.WriteLine("It is \"" + flag + "\" that at most one string swap can be performed on exactly one of the strings.");  
            
        }
    }
}
