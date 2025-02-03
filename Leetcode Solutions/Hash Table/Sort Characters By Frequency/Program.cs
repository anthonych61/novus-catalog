using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// Given a string s, sort it in decreasing order based on the frequency of characters, and return the sorted string.
namespace Sort_Characters_By_Frequency
{    class Program
    {
        static void Main(string[] args)
        {
            String s = "tree";
            StringBuilder sb = new StringBuilder();

            Dictionary<char,int>dict = new Dictionary<char,int>();

            // build dictionary : character and how often it appears
            for(int i = 0; i <= s.Length-1; i++)
            {
                if(!dict.ContainsKey(s[i]))
                    dict.Add(s[i],0);

                dict[s[i]]++;
            }

            foreach(KeyValuePair<char,int> kv in dict.OrderBy(key => key.Key).OrderByDescending(key => key.Value))
            {
                var i = 0;

                while(i < kv.Value) //sort string in decreasing order based on frequency of characters
                {
                    sb.Append(kv.Key);
                    i++;
                }
            }

            Console.WriteLine(sb.ToString());

        }
    }
}
