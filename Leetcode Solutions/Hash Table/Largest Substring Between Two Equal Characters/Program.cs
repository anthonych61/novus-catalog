using System;
using System.Collections.Generic;
using System.Linq;

// Given a string s, return the length of the longest substring between two equal characters, excluding the two characters. If there is no such substring return -1.
// A substring is a contiguous sequence of characters within a string.
namespace Largest_Substring_Between_Two_Equal_Characters
{
    class Program
    {
        static void Main(string[] args)
        {    
            var longestSubString = -1;              
            string s = "mgntdygtxrvxjnwksqhxuxtrv"; 
            Dictionary<char,int> dict = new Dictionary<char,int>();
            
            for(int i = 0; i <= s.Length-1; i++) // build dictionary: character and how often it appears
            {
                if(dict.ContainsKey(s[i]))  { 

                    int getIndex = dict[s[i]];
                    var diff = i - getIndex - 1;
                    longestSubString = Math.Max(longestSubString,diff); // find longest substring
                }
                else
                {
                    dict.Add(s[i],i);  // store key-value pair
                }

            }
            Console.WriteLine(longestSubString);

        }
    }
}
