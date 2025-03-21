namespace Longest_Common_Prefix;

// Write a function to find the longest common prefix string amongst an array of strings.
// If there is no common prefix, return an empty string "".

class Program
{
    static void Main(string[] args)
    {
        var prefix = "";
        var result = "";
        string[] strs = new string[] {"ab", "a"}; // TEST CASES: // {"flower","flow","flight"}; // {"c","acc","ccc"}; // {"dog","racecar","car"};                 
        for(int i = 0; i <= strs[0].Length-1; i++) {
            var count = 0;
            prefix += strs[0][i];            
            for(int j = 1; j <= strs.Length-1; j++) {
                if(prefix.Length <= strs[j].Length && strs[j].IndexOf(prefix,0,prefix.Length) != -1) 
                     count++;                             
            }
            if(count == strs.Length-1) 
                result = prefix;                        
        }
        Console.WriteLine(result); 
    }
    
}
