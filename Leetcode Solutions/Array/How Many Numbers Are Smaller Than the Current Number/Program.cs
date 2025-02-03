// Given the array nums, for each nums[i] find out how many numbers in the array are smaller than it. 
// That is, for each nums[i] you have to count the number of valid j's such that j != i and nums[j] < nums[i].
// Return the answer in an array.

namespace How_Many_Numbers_Are_Smaller_Than_the_Current_Number;

class Program
{
    static void Main(string[] args)
    {
        int[] nums = {8,1,2,2,3};
        int[] result = new int[nums.Length];
        
         for(int i = 0; i <= nums.Length-1; i++) 
         {
             int count = 0;
             for(int j = 0; j <= nums.Length-1; j++)   
             {
                if(nums[j] < nums[i] && j != i)
                    count++;
             }
            result[i] = count;
         }

         for(int j = 0; j <= result.Length-1; j++)
            Console.WriteLine(result[j]);
    }
}
