using System;
using System.Linq;

//Write a function that takes a string as input and reverse only the vowels of a string.
namespace Reverse_Vowels
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "leetcode", vowel = "aeiouAEIOU"; 
            
            char[] ch = s.ToCharArray();  
            int left = 0;   // initialize left and right pointers 
            int right = ch.Length-1;

            // traverse string from both ends until  
            // left and right
            while (left < right)
            {
                 // check for vowel character
                if (!(vowel.IndexOf(ch[right]) >= 0))
                {
                    right--;
                }
                else if(!(vowel.IndexOf(ch[left]) >= 0))
                {
                    left++;
                }
                else // both ch[left] and ch[right] are vowels
                {
                    char temp = ch[left];
                    ch[left++] = ch[right];
                    ch[right--] = temp;
                }
            } 

            Console.WriteLine(new string(ch)); 

        }
    }
}
