using System;
using System.Collections.Generic;

// Given a non-empty array of integers nums, every element appears twice except for one. Find that single one.
// Follow up: Could you implement a solution with a linear runtime complexity and without using extra memory?
// Time Complexity : O(n)
// Auxiliary Space : O(n)
namespace Single_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] {4,1,2,1,2};
            Dictionary<int, int> mp = new Dictionary<int, int>();
             // Traverse through array elements and 
             // count frequencies 
            for(int i = 0; i <= nums.Length-1; i++)
            {
                if(mp.ContainsKey(nums[i]))
                {
                    var val = mp[nums[i]];
                    mp.Remove(nums[i]);
                    mp.Add(nums[i], val+1);                
                }
                else
                {
                    mp.Add(nums[i], 1);
                }
               
            }
            // Traverse through map and print frequencies 
            foreach(KeyValuePair<int, int> entry in mp)
            {
                if(entry.Value == 1)
                {
                    Console.WriteLine(entry.Key);
                }
            }

        }
    }
}
