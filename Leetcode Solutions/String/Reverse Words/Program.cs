using System;
using System.Linq;

//Given a string, you need to reverse the order of characters in each word within a sentence while still preserving whitespace and initial word order.
namespace Reverse_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string newsentence = "", s = "Let's take LeetCode contest";
            string[] wrdArray = s.Split(" ");            

            for(int i = 0; i <= wrdArray.Length-1; i++)
            {
               var c =  string.Join("", wrdArray[i]).ToCharArray();  
               Array.Reverse(c);
               newsentence += new string(c) + " ";  
            } 

            Console.WriteLine(newsentence.Trim());

        }
    }
}
