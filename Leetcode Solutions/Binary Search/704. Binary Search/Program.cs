namespace _704._Binary_Search;

// Given an array of integers nums which is sorted in ascending order, and an integer target, write a function to search target in nums. 
// If target exists, then return its index. Otherwise, return -1.
// You must write an algorithm with O(log n) runtime complexity.

// Complexity
// Time complexity: O(log(N))
// Space complexity: O(1)
class Program
{
     // Returns index of k if it is present in arr[]
    public static int binarySearch(int[] nums, int k)
    {
        int low = 0, high = nums.Length-1;
        
        while(low <= high)
        {
            int mid = low + (high - low) / 2;

            if(nums[mid] == k) // Check if k is present at mid
            {
                return mid;
            }
            else if(nums[mid] < k) // If k greater, ignore left half
            {
                low = mid + 1;
            }
            else // If k is smaller, ignore right half
            {
                high = mid - 1;
            }

        }   

        return -1; // element not present

    }
    static void Main(string[] args)
    {   
        int k = 9; // k = 5    
        int[] arr = new int[] {-1,0,3,5,9,12}; //new int[]{5};  
        
        int result = binarySearch(arr, k);

        if(result != -1)
        {
            Console.WriteLine(k +  " exists in array and its index is " + result);
        }
        else
        {
            Console.WriteLine(result);
        }

    }
}
