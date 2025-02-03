using System;
// Given a non-empty array of integers nums, every element appears twice except for one. Find that single one.
// Follow up: Could you implement a solution with a linear runtime complexity and without using extra memory?
// Time Complexity : O(n)
// Auxiliary Space : O(1)
namespace Single_Number_II
{
    class Program
    {
        static void Main(string[] args)
        {
            int val = 0;
            int[] nums = new int[] {4,1,2,1,2};
            Array.Sort(nums);

            for(int i = 0; i < nums.Length-1; i+=2)
            {
                if(nums[i] != nums[i+1])
                {
                    val = nums[i];
                    break;
                }
            }

            Console.WriteLine(val);

        }
    }
}
