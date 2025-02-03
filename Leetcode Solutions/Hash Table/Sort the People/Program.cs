// You are given an array of strings names, and an array heights that consists of distinct positive integers. Both arrays are of length n.
// For each index i, names[i] and heights[i] denote the name and height of the ith person.
// Return names sorted in descending order by the people's heights.

using System.Globalization;
using System.Reflection.Metadata;

namespace Sort_the_People;
class Program
{
    static void Main(string[] args)
    {
        // int[] heights = {180,165,170};
        // string[] names = {"Mary","John","Emma"};

        int[] heights = {155,185,150};
        string[] names = {"Alice","Bob","Bob"}; 

        /* Solution 1 */
        // Array.Sort(heights, names);              
        // Array.Reverse(names);

        // for(int i = 0; i <= names.Length-1; i++)
        // Console.WriteLine(names[i]);      

        /* Solution 2 */
        int j = 0;
        
        Dictionary <int, string> dict = new Dictionary<int,string>();

        for(int i = 0; i <= names.Length-1; i++)
            dict.Add(heights[i], names[i]);

        foreach(KeyValuePair<int, string> kv in dict.OrderByDescending(key => key.Key)) 
            names[j++] = kv.Value;

        for(int i = 0; i <= names.Length-1; i++)
            Console.WriteLine(names[i]);
            
    }
}
