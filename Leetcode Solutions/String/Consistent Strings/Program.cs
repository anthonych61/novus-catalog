using System;

// You are given a string allowed consisting of distinct characters and an array of strings words. A string is consistent if all characters in the string appear in the string allowed.
// Return the number of consistent strings in the array words.

namespace Consistent_Strings;
class Program
{
    static void Main(string[] args)
    {
        int count = 0;        
        //string allowed = "ab";
        //string[] words = {"ad","bd","aaab","baa","badab"};

        // string allowed = "abc";
        // string[] words = {"a","b","c","ab","ac","bc","abc"};

        string allowed = "cad";
        string[] words = {"cc","acd","b","ba","bac","bad","ac","d"};
       
        for (int i = 0; i < words.Length; i++) // for each' string
        {
            for(int j = 0; j < words[i].Length; j++) // check each char in string
            {
                if(!allowed.Contains(words[i][j])) 
                {
                    count--;
                    break;
                }
            }            
            count++;
        }  

        Console.WriteLine(count);

    }
}
