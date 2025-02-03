using System;
using System.Linq;

// Write a function that reverses a string. The input string is given as an array of characters char[].
// Do not allocate extra space for another array, you must do this by modifying the input array in-place with O(1) extra memory.
// You may assume all the characters consist of printable ascii characters.
namespace Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] s = new char[] {'H','a','n','n','a','h'}; 
            int left = 0;
            int right = s.Length-1;
            
            while(left < right)
            {
                char temp = s[right];
                s[right--] = s[left];
                s[left++] = temp;
                                                
            }

            for(int j = 0; j <= s.Length-1; j++)
                Console.Write(s[j]);
            
            Console.WriteLine();
               
        }
    }
}
