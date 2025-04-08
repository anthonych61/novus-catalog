namespace _35._Search_Insert_Position;

// Given a sorted array of distinct integers and a target value, return the index if the target is found. If not, return the index where it would be if it were inserted in order.
// You must write an algorithm with O(log n) runtime complexity.
// Time complexity: O(log n)
// Space complexity: O(1)
class Program
{
    // returns index of k if it is present in nums[]
    public static int binarySearch(int[] nums, int k)
    {
        int low = 0, high = nums.Length-1;

        while(low <= high)
        {
             int mid = low + (high - low) / 2;

             if(nums[mid] == k) // check if k is present at mid
             {
                return mid;
             }
             else if(nums[mid] < k)  // if k greater, ignore left half
             {
                low = mid + 1;
             }
             else // if k is smaller, ignore right half
             {
                high = mid - 1;
             }

        }

        return low;

    }
    static void Main(string[] args)
    {
        int k = 0;
        int[] arrs = {1,3,5,6};
        int index = binarySearch(arrs, k);

        Console.WriteLine(k + " found at index " + index);

    }
}
