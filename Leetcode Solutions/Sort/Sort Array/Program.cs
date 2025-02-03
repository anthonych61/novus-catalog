using System;

//Given an array of integers nums, sort the array in ascending order.
namespace Sort_Array
{
    class Program
    {
        static void Main(string[] args)
        {
          
           int[] nums = new int[] {1, 9, 3, 5, 2, 4};

           for(int i = 0; i <= nums.Length - 1; i++)
            {
                for(int j = 0; j <= nums.Length - 1; j++)
                {
                    if(nums[i] < nums[j])
                    {
                        int temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                    }
                }
                              
            }

            for(int n = 0; n <= nums.Length - 1; n++)
                Console.WriteLine(nums[n]);

        }
    }
}
