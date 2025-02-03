using System;

// You are given a string s and an integer array indices of the same length. 
// The string s will be shuffled such that the character at the ith position moves to indices[i] in the shuffled string.
namespace Shuffle_String
{
    class Program
    {
        static void Main(string[] args)
        {
           string s = "codeleet";

           // declare variables
           int[] indices = {4,5,6,7,0,2,1,3};
           char[] charArr = new char[s.Length];
          
           // move character at ith position to indice[i]
           for(int i = 0; i <= s.Length-1; i++)
               charArr[indices[i]] = s[i];
          
           Console.WriteLine(new string(charArr)); // shuffled string
        }
    }
}
