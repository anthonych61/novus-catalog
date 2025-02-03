using System;
using System.Linq;

//Given a string S, return the "reversed" string where all characters that are not a letter stay in the same place, and all letters reverse their positions.
namespace Reverse_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "a-bC-dEf-ghIj";
            
            var ch = str.ToCharArray();
            // Initialize left and right pointers 
            int left = 0;   
            int right = ch.Length-1;
           
            
            // Traverse string from both ends until  
            // left and right
            while(left < right)          
            {
                // Ignore special characters
                if(!Char.IsLetter(ch[right]))
                {
                    right--;
                }
                else if(!Char.IsLetter(ch[left]))
                {
                    left++;
                }
                else // Both  ch[left] and ch[right] are not special
                {                    
                    char temp = ch[right];
                    ch[right--] = ch[left];
                    ch[left++] = temp;                      
                }              
                                                                                     
            } 
          
            Console.WriteLine(new string(ch));

        }
    }

}
