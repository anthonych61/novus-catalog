using System.Reflection.Metadata.Ecma335;

namespace _344._Reverse_String;

// Write a function that reverses a string. The input string is given as an array of characters s.
// You must do this by modifying the input array in-place with O(1) extra memory.

// Time complexity:
// O(n) as we are iterating through the array once. Time taken to reverse the string depends on the number of elements in the array.
// Space complexity:
// O(1) as we are not storing any extra variables or data.
class Program
{
    static void Main(string[] args)
    {
        char[] s = {'H','a','n','n','a','h'}; //{'h','e','l','l','o'};       
        int left = 0;
        int right = s.Length-1;        
        string newStr = "";

        while(left <= right)
        {
            char c = s[right];
            s[right] = s[left];
            s[left] = c;   
            right--;
            left++;         
        }

        for(int j = 0; j <= s.Length-1; j++)
            newStr += s[j];

        Console.WriteLine(newStr);
    }
}
