using System;
using System.Text;

// Given an input string s, reverse the order of the words.
// A word is defined as a sequence of non-space characters. The words in s will be separated by at least one space.
// Return a string of the words in reverse order concatenated by a single space.
// Note that s may contain leading or trailing spaces or multiple spaces between two words. The returned string should only have a single space separating the words. 
// Do not include any extra spaces.
// *NOTE - Solve it in-place with O(1) extra space.
namespace Reverse_Words_String
{
    class Program
    {       
        static void Main(string[] args)
        {         
            string s = "  Bob    Loves  Alice   ";            
            var words = s.Split(" "); 
            StringBuilder sb = new StringBuilder();    
            
            for(int i = words.Length-1; i >= 0; i--)
            {
                if(!words[i].Equals(""))
                {
                    sb.Append(words[i]).Append(" ");
                }
            }
            
            Console.WriteLine(sb.ToString().Trim());
        }      
               
    }
}
