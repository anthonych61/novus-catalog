namespace _2540._Minimum_Common_Value;

// Given two integer arrays nums1 and nums2, sorted in non-decreasing order, return the minimum integer common to both arrays. 
// If there is no common integer amongst nums1 and nums2, return -1.
// Note that an integer is said to be common to nums1 and nums2 if both arrays have at least one occurrence of that integer.

// Complexity
// Time complexity: O(n+m)
// Space complexity: O(n)
class Program
{
    static void Main(string[] args)
    {
       int[] nums1 = {1,2,3}, nums2 = {2,4};
       HashSet<int> hs = new HashSet<int>(nums1);

       foreach(var i in nums2)
       {
            if(hs.Contains(i))
                Console.WriteLine("Smallest element common to both arrays is: " + i);
                break;
       }
    }
}
