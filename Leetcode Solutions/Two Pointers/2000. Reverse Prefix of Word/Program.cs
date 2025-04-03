using System.Xml;

namespace _2000._Reverse_Prefix_of_Word;

// Given a 0-indexed string word and a character ch, reverse the segment of word that starts at index 0 and ends at the index of the first occurrence of ch (inclusive). If the character ch does not exist in word, do nothing.
// For example, if word = "abcdefd" and ch = "d", then you should reverse the segment that starts at 0 and ends at 3 (inclusive). The resulting string will be "dcbaefd".
// Return the resulting string.

// Time complexity:
// O(n)
// Space complexity:
// O(n)

// Note: The C++ version uses O(1) space because the characters are reversed in place instead of using an auxiliary data structure. 
// It is recommended to check with your interviewer before modifying the input, as it might lead to issues in certain scenarios.
class Program
{
    static void Main(string[] args)
    {
        string word =  "abcdefd";
        char ch = 'd';  

        // SOLUTION 1
        // int index = word.IndexOf(ch);
        // string word2 = word.Substring(index+1, word.Length - (index+1));
        
        // if(index != -1) 
        // {
        //     word = word.Substring(0, index+1);            
        //     char[] chArray = word.ToCharArray();          
        //     int left = 0, right = word.Length-1;
            
        //     while(left < right) 
        //     {
        //         char temp = chArray[left];
        //         chArray[left] = chArray[right];
        //         chArray[right] = temp;
        //         left++;
        //         right--;
        //     }

        //     word = String.Concat(new string(chArray), word2);
        //     Console.WriteLine(word);

        // }
        // else
        // {
        //     Console.WriteLine(word);
        // }    


        // SOLUTION 2
        int left = 0;
        char[] chArray = word.ToCharArray();

        for(int right = 0; right <= word.Length-1; right++)
        {
            if(chArray[right] == ch) {

                while(left < right) 
                {
                    char temp = chArray[left];
                    chArray[left] = chArray[right];
                    chArray[right] = temp;
                    left++;
                    right--;
                }                
                word = new string(chArray);
                break;

            }
        }

        Console.WriteLine(word);
               
    }
}
