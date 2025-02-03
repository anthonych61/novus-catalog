// A distinct string is a string that is present only once in an array.
// Given an array of strings arr, and an integer k, return the kth distinct string present in arr. If there are fewer than k distinct strings, return an empty string "".
// Note that the strings are considered in the order in which they appear in the array.

namespace Kth_Distinct_String_in_an_Array;
class Program
{
    static void Main(string[] args)
    {
        int k = 2;
        int count = 0;
        string[] arr = {"d","b","c","b","c","a"};
        Dictionary <string,int> dict = new Dictionary<string,int>();
        for(int i = 0; i <= arr.Length - 1; i++)
        {
            if(!dict.ContainsKey(arr[i]))
                dict.Add(arr[i],0);
            dict[arr[i]]++;
        }
        
        foreach (string s in arr) {
            if (dict[s] == 1) {
                count++;
                if (count == k) {
                    Console.WriteLine(s); 
                }
            }
        }
    }
}
