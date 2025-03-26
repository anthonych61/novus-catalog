using System.Runtime.CompilerServices;

namespace _217._Contains_Duplicate;

// Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.
// Time complexity:
// Since we only traverse the array once and each lookup in the HashSet is O(1)the overall time complexity is O(n)
// Space complexity:
// We use additional space to store elements in the HashSet, so the space complexity is O(n)
class Program
{
    static void Main(string[] args)
    {
        // Solution #1
        // Boolean flag = false;
        // int[]nums = new int[]{1,2,3,4}; //{1,2,3,1};
        // HashSet<int> hs = new HashSet<int>();
        // for(int i = 0; i <=nums.Length-1; i++) {

        //     if(!hs.Contains(nums[i]))
        //     {
        //         hs.Add(nums[i]);
        //     }
        //     else
        //     {
        //         flag = true;
        //         break;
        //     }            

        // }               
        // Console.WriteLine(flag);

        // Solution #2 
        int[]nums = new int[]{1,2,3,4}; //{1,2,3,1};
        HashSet<int> hs = new HashSet<int>(nums);        
        if(!(hs.Count == nums.Length))
        {
            Console.WriteLine(true);
        }
        else
        {
            Console.WriteLine(false);
        }  
            
    }
}
