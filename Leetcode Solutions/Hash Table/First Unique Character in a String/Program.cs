using System;
using System.Collections.Generic;

//Given a string s, return the first non-repeating character in it and return its index. If it does not exist, return -1.
namespace First_Unique_Character_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            var at = -1;
            String s = "loveleetcode";
            Dictionary<char,int> dict = new Dictionary<char,int>();
            
            // build dictionary : character and how often it appears
            for(int i = 0; i<= s.Length-1; i++)
            {
                if(!dict.ContainsKey(s[i]))
                    dict.Add(s[i],0);

                dict[s[i]]++;                
            }
            // find the index
            foreach(KeyValuePair<char,int> kv in dict)
            {
                if(kv.Value == 1)
                {
                    at = s.IndexOf(kv.Key, 0, s.Length);
                    break;
                }
            }    

            Console.WriteLine("Index : " + at);
            
        }
    }
}
