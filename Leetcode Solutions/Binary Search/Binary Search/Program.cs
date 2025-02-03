using System;

// Given an array of integers nums which is sorted in ascending order, and an integer target, write a function to search target in nums. 
// If target exists, then return its index. Otherwise, return -1.
// You must write an algorithm with O(log n) runtime complexity.
// Time Complexity: O(logN)
// Space Complexity: O(1) since it's a constant space solution.
namespace Binary_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            bool found = false;
            int[] nums = new int[] {-1,0,3,5,9,12};
            int left = 0, right = nums.Length-1, target = 9;
            while(left <= right) {

                int mid = left + (right - left) / 2;

                if(target == nums[mid])     //check if target is present at mid
                {
                    found = true;
                    Console.WriteLine("Item " + target + " is at Index " + mid);
                    break;
                }
                else if (target > nums[mid])        //if greater than mid , ignore left half
                {
                    left = mid + 1;                    
                }
                else            //if smaller than mid , ignore right half
                {
                    right = mid - 1;                                      
                }

            } 
                       
            if(!found)
            {
                Console.WriteLine(-1);  //element not present
            }

        }
    }
}
