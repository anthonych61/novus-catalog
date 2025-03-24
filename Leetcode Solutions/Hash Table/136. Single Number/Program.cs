using System.ComponentModel;
using System.Security.Cryptography;

namespace _136._Single_Number;
// Given a non-empty array of integers nums, every element appears twice except for one. Find that single one.
// You must implement a solution with a linear runtime complexity and use only constant extra space.
/*
Create a HashSet to store the unique values.
Loop the nums array, the first time a value appears, we add it to the HashSet, the second time we remove it from the HashSet.
At the end only one value will remain in the HashSet, so we return that value.

Complexity
Time complexity: O(n)
Space complexity: O(1)
*/
class Program
{
    static void Main(string[] args)
    {        
       /* 
       //SOLUTION 1 - Dictionary
       int[] nums = new int[]{1,2,4,1,2}; 
       Dictionary<int, int> dict = new Dictionary<int, int>();
       
        for(int i = 0; i <= nums.Length-1; i++) {
            if(!dict.ContainsKey(nums[i]))
                dict.Add(nums[i],0);
            dict[nums[i]]++;
        }
       
        var result = dict.Where(s => s.Value == 1).Select(s => s.Key).ToArray()[0];
        Console.WriteLine(result);
        */

        //SOLUTION 2 - Hashset
        int[] nums = new int[]{1,2,4,1,2}; 
        HashSet<int> hs = new HashSet<int>();

        for(int i = 0; i <= nums.Length-1; i++)
        {
            if(!hs.Contains(nums[i]))
            {
                hs.Add(nums[i]);
            }
            else
            {
                hs.Remove(nums[i]);
            }
        }

        Console.WriteLine(hs.First());        
        
    }
}
