using System;
using System.Collections.Generic;

// A pangram is a sentence where every letter of the English alphabet appears at least once.
// Given a string sentence containing only lowercase English letters, return true if sentence is a pangram, or false otherwise.
namespace Check_if_the_Sentence_Is_Pangram
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "thequickbrownfoxjumpsoverthelazydog";
            HashSet<char> hs = new HashSet<char>();
            
            for(int i = 0; i <= sentence.Length-1; i++)
            {
                if(!hs.Contains(sentence[i]))
                    hs.Add(sentence[i]);
            }

            if(hs.Count == 26)
            {
                Console.WriteLine("Pangram");
            }
            else
            {
                Console.WriteLine("Not Pangram");
            }
            
        }
    }
}
