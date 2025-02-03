using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

// A sentence is a string of single-space separated words where each word consists only of lowercase letters.
// A word is uncommon if it appears exactly once in one of the sentences, and does not appear in the other sentence.
// Given two sentences s1 and s2, return a list of all the uncommon words. You may return the answer in any order. 
namespace Uncommon_Words_from_Two_Sentences
{
    class Program
    {
        static void Main(string[] args)
        {   
            StringBuilder uncommonWrd = new StringBuilder();
            string s1 = "this apple is sweet", s2 = "this apple is sour";
            string [] strArr = String.Concat(s1, ' ', s2).Split(' '); 
            Dictionary <string,int> dict = new Dictionary<string,int>();
           
            for(int i  = 0; i <= strArr.Length-1; i++) // store words as key value pairs dictionary
            {
                if(!dict.ContainsKey(strArr[i]))
                    dict.Add(strArr[i], 0);

                dict[strArr[i]]++;

            }
        
            foreach(KeyValuePair<string,int> kv in dict)
            {
                if(kv.Value == 1)   // retrieve uncommon words that only appear once dictionary
                     uncommonWrd.Append(kv.Key + ' ');     
            }  
            Console.WriteLine(uncommonWrd.ToString().Trim());                    
                      
        }
    }
}
