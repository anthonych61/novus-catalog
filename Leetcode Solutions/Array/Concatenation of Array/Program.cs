namespace _1929._Concatenation_of_Array;

// Given an integer array nums of length n, you want to create an array ans of length 2n where ans[i] == nums[i] and ans[i + n] == nums[i] for 0 <= i < n (0-indexed).
// Specifically, ans is the concatenation of two nums arrays.
// Return the array ans.
class Program
{
    static void Main(string[] args)
    {
        int[] nums = new int[] {1, 4, 7};
        int n = nums.Length;
        int[] ans = new int[n * 2];

        //concatenate two nums arrays
        for(int i = 0; i <= nums.Length-1; i++)
           ans[i] = ans[n + i] = nums[i];

        //return the array ans
        for(int j = 0; j <= ans.Length-1; j++)
            Console.Write(ans[j] + " ");

        Console.WriteLine();

    }
}
