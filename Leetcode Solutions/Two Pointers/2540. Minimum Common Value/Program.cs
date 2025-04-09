namespace _2540._Minimum_Common_Value;

// Given two integer arrays nums1 and nums2, sorted in non-decreasing order, return the minimum integer common to both arrays. 
// If there is no common integer amongst nums1 and nums2, return -1.
// Note that an integer is said to be common to nums1 and nums2 if both arrays have at least one occurrence of that integer.

// Complexity
// Time complexity: O(n+m)
// We iterate through nums1 and nums2 using two pointers
// Space complexity: O(1)
// We use a couple of variables and no additional data structures that grow with input size, so the space complexity is constant, O(1).
class Program
{
    public static int CommonValue(int[]arr1, int[]arr2){
        int ptr1 = 0, ptr2 = 0;
        while(ptr1 <= arr1.Length-1 && ptr2 < arr2.Length-1) {
            if(arr1[ptr1] == arr2[ptr2]) {
                return arr1[ptr1];
            }
            else if(arr1[ptr1] < arr2[ptr2]) {
                ptr1 = ptr1 + 1;
            }
            else {
                ptr2 = ptr2 + 1;
            }
        }
        return -1;
    }
    static void Main(string[] args)
    {
        int[] nums1 = {1,2,3}, nums2 = {2,4};
        int result = CommonValue(nums1, nums2);
        Console.WriteLine("Smallest element common to both arrays is: " + result);        
    }
}
