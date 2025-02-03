using System;
using System.Collections.Generic;

// Given an array of integers nums containing n + 1 integers where each integer is in the range [1, n] inclusive.
// There is only one repeated number in nums, return this repeated number.
// Follow up:
// How can we prove that at least one duplicate number must exist in nums?
// Can you solve the problem without modifying the array nums?
// Can you solve the problem using only constant, O(1) extra space?
// Can you solve the problem with runtime complexity less than O(n2)?
namespace Find_the_Duplicate_Number
{
    class Program
    {
        static void Main(string[] args)
        {
           int[] nums = new int[] {1,3,4,2,2};
           HashSet<int> hashset = new HashSet<int>(); //create hashset of integers
           //A HashSet is an unordered collection of the unique elements. 
           //It is found in System.Collections.Generic namespace. It is used in a situation where we want to prevent duplicates from being inserted in the collection.
           //insert elements into hashset
           for(int i = 0; i <= nums.Length-1; i++)
           {
               if(hashset.Contains(nums[i]))
                    Console.WriteLine(nums[i]);

               hashset.Add(nums[i]);
           }          

        }
    }
}
