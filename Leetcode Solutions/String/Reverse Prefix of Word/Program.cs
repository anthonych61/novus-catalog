using System;

// Given a 0-indexed string word and a character ch, reverse the segment of word that starts at index 0 and ends at the index of the first occurrence of ch (inclusive). 
// If the character ch does not exist in word, do nothing.
// For example, if word = "abcdefd" and ch = "d", then you should reverse the segment that starts at 0 and ends at 3 (inclusive). The resulting string will be "dcbaefd".
// Return the resulting string.
namespace Reverse_Prefix_of_Word
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = "", word = "abcdefd";
            char ch = 'd';
            int index = word.IndexOf(ch);  //reports the zero-based index of the first occurrence of a specified character. 
            //The method returns -1 if the character or string is not found in this instance.
            if(index != -1)
            {
                for(int i = index; i >= 0; i--) // reverse string
                {
                    result += word[i];
                } 
                result = result + word.Substring(index+1);
            }
            else 
            {
                result = word;            
            }  
            Console.WriteLine(result);           

        }
    }
}
