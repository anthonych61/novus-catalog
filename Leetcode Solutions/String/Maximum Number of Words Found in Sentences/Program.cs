using System;

// A sentence is a list of words that are separated by a single space with no leading or trailing spaces.
// You are given an array of strings sentences, where each sentences[i] represents a single sentence.
// Return the maximum number of words that appear in a single sentence.
namespace Maximum_Number_of_Words_Found_in_Sentences
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxNumberOfWords = 0;            
            string[] sentences = {"alice and bob love", "i think so too", "this is great thanks very much"};
            
            for(int i = 0; i <= sentences.Length-1; i++)
            {
                maxNumberOfWords = Math.Max(maxNumberOfWords, sentences[i].Split(' ').Length);               
            }

            Console.WriteLine(maxNumberOfWords);
        }
    }
}
