namespace Is_Subsequence;

//Given two strings s and t, return true if s is a subsequence of t, or false otherwise.
//A subsequence of a string is a new string that is formed from the original string by deleting some (can be none) of the characters without disturbing the relative positions of the remaining characters. 
//(i.e., "ace" is a subsequence of "abcde" while "aec" is not).
class Program
{
    static void Main(string[] args)
    {
        int k = 0;
        int numChars = 0;
        string  s = "abc", t = "ahbgdc"; 

        for(int i = 0; i <= s.Length-1; i++)
        {
            for(int j= k; j <= t.Length-1; j++)
            {
                if(s[i] == t[j])
                {
                    k = j+1;
                    numChars++;
                    break; 
                }
               
            }
            
        }

        if(s.Length == numChars) 
        {
            Console.WriteLine(true);
        }
        else
        {
            Console.WriteLine(false);
        }         
        
    }
}
