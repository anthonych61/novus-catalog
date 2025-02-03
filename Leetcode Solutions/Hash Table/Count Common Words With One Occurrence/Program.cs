
using System;
using System.Collections.Generic;

// Given two string arrays words1 and words2, return the number of strings that appear exactly once in each of the two arrays.
namespace Count_Common_Words_With_One_Occurrence
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            string[] words1 = {"leetcode","is","amazing","as","is"}, 
                     words2 = {"amazing","leetcode","is","is"};
            Dictionary <string, int> mp1 = new Dictionary<string, int>();
            Dictionary <string, int> mp2 = new Dictionary<string, int>();

            // store elements in words1 into dictionary
            for(int i = 0; i <= words1.Length-1; i++)
            {
                // if not present add key to dictionary
                if(!mp1.ContainsKey(words1[i]))
                    mp1.Add(words1[i],0);
                mp1[words1[i]]++; // increment value           
            }

            for(int j = 0; j <= words2.Length-1; j++)
            {
                if(!mp2.ContainsKey(words2[j]))
                    mp2.Add(words2[j],0);
                mp2[words2[j]]++;        
            }

            foreach(KeyValuePair<string, int> pair in mp1)
            {
                int val1, val2;                
                if(mp2.TryGetValue(pair.Key, out val1) && mp1.TryGetValue(pair.Key, out val2)) // get value associated with specified key
                    if(val1 == 1 && val2 == 1)
                        count++;
            }
            Console.WriteLine("Count : " + count);  // return number of strings

        }
    }
}
