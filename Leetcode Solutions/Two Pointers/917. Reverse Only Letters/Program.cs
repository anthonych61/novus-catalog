namespace _917._Reverse_Only_Letters;

// Given a string s, reverse the string according to the following rules:
// All the characters that are not English letters remain in the same position.
// All the English letters (lowercase or uppercase) should be reversed.
// Return s after reversing it.
// Complexity
// Time complexity: O(n)
// Space complexity: O(n)
class Program
{
    static void Main(string[] args)
    {
        string s = s = "a-bC-dEf-ghIj"; //"Test1ng-Leet=code-Q!";
        char[] ch = s.ToCharArray();
        int left = 0, right = s.Length-1;

        // Traverse string from both ends until  
        // left and right
        while(left < right) {
            // Ignore special characters
            if(!char.IsLetter(ch[left])) {
                left++;
            }
            else if(!char.IsLetter(ch[right])) {
                right--;
            }
            else // Both  ch[left] and ch[right] are not special
            {
                char temp = ch[left];
                ch[left] = ch[right];
                ch[right] =  temp;
                left++;
                right--;
            }
        }

        Console.WriteLine(new string(ch));
    }
}
