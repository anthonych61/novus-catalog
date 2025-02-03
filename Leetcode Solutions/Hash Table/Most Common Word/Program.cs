using System;
using System.Collections.Generic;
using System.Linq;

// Given a string paragraph and a string array of the banned words banned, return the most frequent word that is not banned. 
// It is guaranteed there is at least one word that is not banned, and that the answer is unique.
// The words in paragraph are case-insensitive and the answer should be returned in lowercase.
namespace Most_Common_Word
{
    class Program
    {
        static void Main(string[] args)
        {
            string paragraph = "Bob hit a ball, the hit BALL flew far after it was hit.";
            string[] word = paragraph.ToLower().Split(new char[]{' ','!','?','\'',',',';','.'}, StringSplitOptions.RemoveEmptyEntries);
            string[] banned = {"hit"};
           
            HashSet<string> hs = new HashSet<string>();
            Dictionary<string,int> dict = new Dictionary<string,int>();
           
            // a hashset is an unordered collection of unique elements
            // add the elements in a hashset
            foreach(var i in banned)
            {
                hs.Add(i);
            }

            // traverse through array elements and 
            // count the frequencies
            for(int j = 0; j <= word.Length-1; j++)
            {
                if(!dict.ContainsKey(word[j]))
                    dict.Add(word[j],0);                
                dict[word[j]]++;  
                                                   
            }
            Console.WriteLine(dict.OrderByDescending(w => w.Value).Where(w => !hs.Contains(w.Key)).First().Key);            
            
        }
    }
}
