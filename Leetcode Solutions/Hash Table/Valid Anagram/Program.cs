using System;

// Given two strings s and t, return true if t is an anagram of s, and false otherwise.
// We count occurrences of each letter in the two strings and compare them. 
// Since both s and t contain only letters from a-z, a simple counter table of size 26 is suffice.
// Do we need two counter tables for comparison? Actually no, because we could increment the counter for each letter in s and decrement the counter for each letter in t, 
// then check if the counter reaches back to zero.

// Complexity analysis
// * Time complexity : O(n). Time complexity is O(n) because accessing the counter table is a constant time operation.
// * Space complexity : O(1). Although we do use extra space, the space complexity is O(1) because the table's size stays constant no matter how large n is.
namespace Valid_Anagram_I
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            string s = "anagram", t = "nagaram"; // s= "rat", t= "car";  
            int [] count = new int[26];

            // check that length is the same 
            if(s.Length != t.Length)          
            { 
                flag = false;     
            }
            else
            {  
                // increment value in count for corresponding array 
                for(int i = 0; i <= s.Length-1; i++)
                { 
                    count[s[i] - 'a']++;
                    count[t[i] - 'a']--;                
                } 

                // check if non-zero number found in array 
                for(int j = 0; j <= count.Length-1; j++) 
                {
                    if(count[j] != 0)
                        flag = false;
                }   

            }
           
            Console.WriteLine(s + " " + t );
            Console.WriteLine(flag);     
        }
    }
}
