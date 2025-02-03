using System;
using System.Collections.Generic;
using System.Linq;

//Given an array of size n, find the majority element. The majority element is the element that appears more than ⌊ n/2 ⌋ times.
//You may assume that the array is non-empty and the majority element always exist in the array.
namespace Majority_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = {3,3,4};
            Dictionary<int, int> mp = new Dictionary<int, int>();
        
            // Traverse through array elements and 
            // count frequencies 
            for(int i = 0; i <= nums.Length-1; i++)
            {
                if(mp.ContainsKey(nums[i]))
                {
                    var val = mp[nums[i]];
                    mp.Remove(nums[i]);
                    mp.Add(nums[i], val +1);
                }
                else
                {
                    mp.Add(nums[i], 1);
                }
                
            }
            Console.WriteLine(mp.Aggregate((l,r) => l.Value > r.Value ? l : r).Key);
        }
    }
}
