using System;
using System.Text;

// Given a string s, check if it can be constructed by taking a substring of it and appending multiple copies of the substring together.
namespace Repeated_Substring_Pattern;

class Program
{
    static void Main(string[] args)
    {
        string s =  "abaababaab"; //"abcabc"; //"aaa"; //"babbabbabbabbab";  //"aba";  // "abcabcabcabc";         
        int half = s.Length/2;
        StringBuilder sb = new StringBuilder();
        string substr = s.Substring(0, half);
        
        for(int i = 1; i <= substr.Length; i++) 
        {
            if (s.Length % i == 0) 
            {
                sb = new StringBuilder();
                for(int j = 0; j < s.Length  / i; j++) 
                    sb.Append(substr.Substring(0, i));   
             }                                       
        }  

        if(sb.ToString() == s) 
        {
            Console.WriteLine(true);
        }
        else
        {
            Console.WriteLine(false);
        }          

    }
}
