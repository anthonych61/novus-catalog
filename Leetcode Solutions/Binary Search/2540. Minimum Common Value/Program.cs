using System.Globalization;

namespace _2540._Minimum_Common_Value;

// Given two integer arrays nums1 and nums2, sorted in non-decreasing order, return the minimum integer common to both arrays. 
// If there is no common integer amongst nums1 and nums2, return -1.
// Note that an integer is said to be common to nums1 and nums2 if both arrays have at least one occurrence of that integer.

// Complexity
// Time Complexity - O(Log n + m)
// Space Complexity - O(1)
class Program
{
    private static bool binarySearch(int[]arr, int k)
    {
        int low = 0 , high = arr.Length-1;

        while(low <= high)
        {
            int mid = low + (high - low) / 2;

            if(arr[mid] == k) // Check if k is present at mid
            {
                return true;
            }
            else if(arr[mid] < k) // If k greater, ignore left half
            {
                low = mid + 1;
            }
            else // If k is smaller, ignore right half
            {
                high = mid - 1;
            }

        }

        return false; // element not present
    }
    static void Main(string[] args)
    {
        int[] nums1 = {1,2,3}, nums2 = {2,4};

        if(nums1.Length > nums2.Length) {

            foreach(var i in nums2) {
                if(binarySearch(nums1, i)) {
                    Console.WriteLine("Smallest element common to both arrays is: " + i);
                        break;
                }                                
            }

        } else {
       
            foreach(var j in nums1) {
                if(binarySearch(nums2, j)) {
                    Console.WriteLine("Smallest element common to both arrays is: " + j);
                        break;
                }            
            }
        }
               
    }
}
