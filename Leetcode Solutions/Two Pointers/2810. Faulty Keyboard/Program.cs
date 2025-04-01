using System.Text;

namespace _2810._Faulty_Keyboard;

// Your laptop keyboard is faulty, and whenever you type a character 'i' on it, it reverses the string that you have written. Typing other characters works as expected.
// You are given a 0-indexed string s, and you type each character of s using your faulty keyboard.
// Return the final string that will be present on your laptop screen.

// Time Complexity:
// O(n) since each character is processed only once.
// Space Complexity:
// O(n) for storing the result in a character array.
class Program
{
    public static string ReverseString(string s)
    {
        char[] ch = s.ToCharArray();
        int left = 0, right = s.Length-1;
        while(left < right) {
            char temp = ch[left];
            ch[left] = ch[right];
            ch[right] = temp;
            left++;
            right--;
        }

        return new string(ch);
    }
    static void Main(string[] args)
    {
        string s = "poiinter"; 
        StringBuilder sb = new StringBuilder();
        for(int i = 0; i <= s.Length-1; i++) 
        {
            if(s[i] != 'i') 
            {                
                sb.Append(s[i]);
            }
            else 
            {
                string newStr = ReverseString(sb.ToString());                
                sb.Clear();
                sb.Append(newStr);
            }
        }
        Console.WriteLine(Convert.ToString(sb));

    }
}
