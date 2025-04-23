
using System.Data;

namespace _349._Intersection_of_Two_Arrays;

// Given two integer arrays nums1 and nums2, return an array of their intersection. Each element in the result must be unique and you may return the result in any order.

// Complexity
// Time complexity:  O(nlogn+mlogm), where n and m are the arrays' lengths. This dominating term comes from the need to sort both input arrays at the beginning of the solution.
// Space complexity: O(min(m,n)), in the worst case when all elements in the smaller array are unique and present in the larger array. This space is necessary to store elements in the set.
class Program
{
    public static int[] Intersection(int[] nums1, int[] nums2) {

        int i = 0;
        int j = 0;
        // sort both arrays        
        Array.Sort(nums1); 
        Array.Sort(nums2);      
        HashSet<int> hs = new HashSet<int>();        
        // iterate the pointers from left to right
        while(i <= nums1.Length-1 && j <= nums2.Length-1)
        {
            if(nums1[i] == nums2[j]) 
            {
                hs.Add(nums1[i]);  
                i++;
                j++;           
            }
            else if(nums1[i] < nums2[j]) // increment the pointer of the smaller integer
            {
                i++;
            }
            else
            {
                j++;
            }
        }
        // return result
        return hs.ToArray(); 
        
    }
    static void Main(string[] args)
    {
        int[] nums1 = {4,9,5};
        int[] nums2 = {9,4,9,8}; 
        int[] intersect  = Intersection(nums1, nums2);

        Console.WriteLine("[Output:]");
        
        for(int i = 0; i <= intersect.Length-1; i++)
            Console.WriteLine(intersect[i]);       
        
    }
}
