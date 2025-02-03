using System;
using System.Text;

// A sentence is a list of words that are separated by a single space with no leading or trailing spaces. 
// Each of the words consists of only uppercase and lowercase English letters (no punctuation).
// For example, "Hello World", "HELLO", and "hello world hello world" are all sentences.
// For example, "Hello World", "HELLO", and "hello world hello world" are all sentences.
namespace Truncate_Sentence
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 4;
            string s = "Hello how are you Contestant";
            string[] words = s.Split(' ');
            StringBuilder sb = new StringBuilder();        
            for(int i = 0; i < k; i++)
            {
                sb.Append(words[i] + " ");
            }
            Console.WriteLine(sb.ToString().Trim());     
        }
    }
}
