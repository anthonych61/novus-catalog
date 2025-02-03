using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

// Given a sorted array nums, remove the duplicates in-place such that each element appear only once and return the new length.
// Do not allocate extra space for another array, you must do this by modifying the input array in-place with O(1) extra memory
namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int j = 0; 
            int[] nums = new int[] {1, 2, 3, 3, 3, 4, 8};

            if(nums.Length == 0)
                j = 0;
                
            for(int i = 0;i< nums.Length-1;i++)
            {
                if(nums[i] != nums[i+1])
                    nums[j++] = nums[i];
            }            
            nums[j++] = nums[nums.Length-1];

            Console.WriteLine("Number of Unique element(s): " + j);
        

        }
    }
}
