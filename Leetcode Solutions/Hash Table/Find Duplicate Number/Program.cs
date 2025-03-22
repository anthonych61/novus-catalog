namespace Find_Duplicate_Number;

// Given an array of integers nums containing n + 1 integers where each integer is in the range [1, n] inclusive.
// There is only one repeated number in nums, return this repeated number.
// You must solve the problem without modifying the array nums and using only constant extra space.
class Program
{
    static void Main(string[] args)
    {
        int[] nums = new int[]{ 1,3,4,2,2 };
        HashSet<int> hs = new HashSet<int>();
        for(int i = 0; i <= nums.Length-1; i++)
        {
            if(!hs.Contains(nums[i])) {
                hs.Add(nums[i]);
            }
            else {
                Console.WriteLine(nums[i]);
                break;
            }
        }
    }
}
