using System;

// Given an array of strings words, return the first palindromic string in the array. If there is no such string, return an empty string "".
// A string is palindromic if it reads the same forward and backward.

namespace Find_First_Palindromic_String_in_the_Array;
class Program
{
    public static bool isPalindrome(string words)
    {
        int left = 0;   
        int right = words.Length-1;  

        while(left < right)
        {
            char[] wrd = words.ToCharArray();
            if (wrd[left] != wrd[right]) 
            {
                return false;
            }

            left++;
            right--;
        }
        
        return true;

    }

    static void Main(string[] args)
    {
        string[] words = {"abc","car","ada","racecar","cool"};  

        /* Approach 1: Reverse String */
        // foreach (var word in words)
        // {
        //     char[] ch = word.ToCharArray();
        //     Array.Reverse(ch);
        //     var reverseStr = new String(ch);        
        //     if(word == reverseStr)
        //     {
        //         Console.WriteLine(word);
        //         break;
        //     }
        // }

        /* Approach 2. Two pointers approach */      
        for(int i = 0; i <= words.Length-1; i++) 
        {            
            if(isPalindrome(words[i])) 
            {
                Console.WriteLine(words[i]);
                break;
            }
        }         

    }
}
