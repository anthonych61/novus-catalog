using System.Text;

namespace _125._Valid_Palindrome;

// A phrase is a palindrome if, after converting all uppercase letters into lowercase letters and removing all non-alphanumeric characters, it reads the same forward and backward. Alphanumeric characters include letters and numbers.
// Given a string s, return true if it is a palindrome, or false otherwise.

// Approach
// Keep incrementing the start and decrementing the end.
// If the character is not a letter or digit, just increment or decrement it (ignore it).
// If the characters are not equal, return false.
// If all checks pass, return true (it is a palindrome).
// Complexity
// Time complexity: O(n)
// Space complexity: O(1)
class Program
{
    static void Main(string[] args)
    {
        bool flag = true;
        string s = "A man, a plan, a canal: Panama"; 
        char[] ch = s.ToCharArray();
        int left = 0, right = s.Length-1;
        // converting all uppercase letters into lowercase letters
        // removing all non-alphanumeric characters      
        while(left < right)
        { 
            if(!Char.IsLetter(ch[left]) && !Char.IsDigit(ch[left]) ) {
                ch[left] = '\0';
                left++;
            }
            else if(!Char.IsLetter(ch[right]) && !Char.IsDigit(ch[right])) {
                ch[right] = '\0';
                right--;
            }
            else if(char.ToLower(ch[left]) != char.ToLower(ch[right])) {
                flag = false;
                break;
            }
            else 
            {   
                left++;
                right--;  
            } 

        }   

        if(flag)
        {
            Console.WriteLine(new string(ch) + " is a palindrome!");
        }
        else
        {
            Console.WriteLine(new string(ch) + " is not a palindrome!");
        }
        
    }
}
