namespace First_Letter_to_Appear_Twice;

// Given a string s consisting of lowercase English letters, return the first letter to appear twice.
// Note:
// A letter a appears twice before another letter b if the second occurrence of a is before the second occurrence of b.
// s will contain at least one letter that appears twice.
class Program
{
    static void Main(string[] args)
    {
        string s = "abccbaacz";
        HashSet<int> hashset = new HashSet<int>();
        foreach(char ch in s)
        {
            if(hashset.Contains(ch))
            {
                Console.Write(ch);
                break;
            }

            hashset.Add(ch);
        }

        Console.WriteLine();
    }
}
