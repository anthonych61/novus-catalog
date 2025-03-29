namespace _345._Reverse_Vowels_of_a_String;

// Given a string s, reverse only all the vowels in the string and return it.
// The vowels are 'a', 'e', 'i', 'o', and 'u', and they can appear in both lower and upper cases, more than once.
// Complexity
// Time complexity: O(n)
// Space complexity: O(n)
class Program
{
    static void Main(string[] args)
    {
        string s = "IceCreAm", vowel ="aeiou";       
        char[] ch = s.ToCharArray();
        int right = s.Length-1, left = 0;       

        // traverse string from both ends until  
        // left and right
        while(left < right) {

            // check for vowel character
            if(!vowel.Contains(char.ToLower(ch[left]))) {
                left++;
            }
            else if(!vowel.Contains(char.ToLower(ch[right]))) {
                right--;
            }
            else { // both ch[left] and ch[right] are vowels
                char temp = ch[left];
                ch[left]= ch[right];
                ch[right] = temp;
                left++;
                right--;
            }           
        }

        Console.WriteLine(new string(ch));
    }
}
