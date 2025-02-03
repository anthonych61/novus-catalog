using System;

// Given a string s, return true if the s can be palindrome after deleting at most one character from it.

// We can solve this problem by finding the position of mismatch. We start looping in the string by keeping two pointers at both the ends which traverse towards mid position after each iteration, 
// this iteration will stop when we find a mismatch, as it is allowed to remove just one character we have two choices here,
// At mismatch, either remove character pointed by left pointer or remove character pointed by right pointer.
// We will check both the cases, remember as we have traversed equal number of steps from both sides, this mid string should also be a palindrome after removing one character, 
// so we check two substrings, one by removing left character and one by removing right character and if one of them is palindrome then we can make complete string palindrome by removing corresponding character, 
// and if both substrings are not palindrome then it is not possible to make complete string a palindrome under given constraint. 

// Time complexity : O(N)
// Space Complexity : O(1)
namespace Valid_Palindrome_II
{
    class Program
    {
        static void Main(string[] args)
        {
           bool flag = true;
           string s=  s= "aydmda"; // "abba" // "abba" // "abecbea"
           int left = 0;
           int right = s.Length-1;

           Console.WriteLine(s);

           while(left < right)
           {
               if(s[left] != s[right])
               {
                   flag = isPalindrome(s, left+1, right) || isPalindrome(s, left, right-1) ;
               }
               right--;
               left++;
           }

           Console.WriteLine(flag);
        }
        // Utility method to check if substring from low to high is
        // palindrome or not.
        static bool isPalindrome(string s, int l, int r)
        {
           int left = l;
           int right = r;
           while(left < right)
           {
               if(s[left] != s[right])
               {
                   return false;
               }
               right--;
               left++;
           }
            return true;
        }
     
    }   
    
}
