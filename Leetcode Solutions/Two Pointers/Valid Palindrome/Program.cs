using System;
using System.Text.RegularExpressions;

// Given a string s, determine if it is a palindrome, considering only alphanumeric characters and ignoring cases.
namespace Valid_Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            string s = "A man, a plan, a canal: Panama";

            Regex rgx = new Regex("[^A-Za-z0-9]+"); // remove all special characters, punctuation and spaces from string, filter out all non alpha numeric characters
            string newStr = rgx.Replace(s, "").ToLower();
            int left = 0, right = newStr.Length-1;

            while(left <= right)
            {
                  if(!newStr[left].ToString().Equals(newStr[right].ToString())) { // use two pointers to compare pairs within string  
                        flag = false; 
                  }       
                  right--; 
                  left++;  
            } 

            Console.WriteLine(flag);
           
        }
    }
}
