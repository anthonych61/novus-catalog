using System;

//Given a binary array nums, return the maximum number of consecutive 1's in the array.
//Constraints:
//1 <= nums.length <= 105
//nums[i] is either 0 or 1.
namespace Max_Consecutive_Ones
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxCount = 0;
            int count = 0;           
            int[] nums = new int[]{1,1,0,1,1,1};
            for(int i = 0; i <= nums.Length-1;i++) {
                if(nums[i] == 1) {
                    count++; //count consecutive 1's
                }
                else {
                    count = 0;
                }
                maxCount = Math.Max(maxCount, count);   //return maximum number of consecutive 1's
            }
            Console.WriteLine(maxCount);
        }
    }
}
