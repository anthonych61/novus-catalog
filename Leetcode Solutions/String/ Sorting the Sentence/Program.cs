using System;
using System.Collections.Generic;

// A sentence is a list of words that are separated by a single space with no leading or trailing spaces. Each word consists of lowercase and uppercase English letters.
// A sentence can be shuffled by appending the 1-indexed word position to each word then rearranging the words in the sentence.
// For example, the sentence "This is a sentence" can be shuffled as "sentence4 a3 is2 This1" or "is2 sentence4 This1 a3".
// Given a shuffled sentence s containing no more than 9 words, reconstruct and return the original sentence.
namespace Sorting_the_Sentence
{
    class Program
    {
        static void Main(string[] args)
        {
           String s = "is2 sentence4 This1 a3";           
           String[] wrd = s.Split(' ');
           var sentence = new String[s.Split(' ').Length + 1];
          
           for(int i = 0; i < wrd.Length; i++)
           {
                String newWrd = wrd[i].Substring(0, wrd[i].Length-1);
                int pos = int.Parse(wrd[i].Substring(wrd[i].Length-1));

                sentence[pos] = newWrd;

           }
           Console.WriteLine(string.Join(" ", sentence).Trim());           
       
        }
    }
}
