using System;

//Given a string s, the power of the string is the maximum length of a non-empty substring that contains only one unique character.
//Return the power of the string.
//Constraints:
//1 <= s.length <= 500
//s contains only lowercase English letters.
namespace Consecutive_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 1, largest = 0;
            string s = "hooraaaaaaaaaaay";

            if(s.Length == 1) 
                    largest = 1;
            
            for(int i = 0; i < s.Length-1; i++) {                
                if(s[i] == s[i+1]) {
                    count++; //count consecutive characters in substring
                }
                else {
                    count = 1; 
                }                
                largest = Math.Max(largest, count); //returns the larger of the two specified numbers
                        
            }
            Console.WriteLine(largest);

        }
    }
}
