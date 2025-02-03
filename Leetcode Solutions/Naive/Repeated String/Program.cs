using System;

//There is a string, s, of lowercase English letters that is repeated infinitely many times. 
//Given an integer, n, find and print the number of letter a's in the first n letters of the infinite string.
//Example
//s = 'abacac'
//n = 10
//The substring we consider is abcacabcac, the first 10 characters of the infinite string. There are 4 occurrences of a in the substring.
namespace Repeated_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "bab";  
            long result = 0, remainderLeft = 0, count = 0, n = 725261545450;

            for(int i = 0; i <= s.Length-1; i++) 
            { 
                if(s[i] == 'a')
                     count++;     //count numnber of a's
            }

            for(int i = 0; i <= n % s.Length-1; i++)
            {
                if(s[i] == 'a') 
                    remainderLeft++; //count remaining a's in substring
            }
            
            result = count * (n / s.Length) + remainderLeft; //add remaining a's to get a result

            Console.WriteLine(s + "\n" + result);
            
        }
    }
}
