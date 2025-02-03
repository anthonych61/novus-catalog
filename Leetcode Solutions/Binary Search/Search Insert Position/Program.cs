using System;

// Given a sorted array of distinct integers and a target value, return the index if the target is found. If not, return the index where it would be if it were inserted in order.
// You must write an algorithm with O(log n) runtime complexity.
// Time Complexity: O(log N)
// Space Complexity: O(1) since it's a constant space solution.
namespace Search_Insert_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            bool found = false;
            int[] nums = new int[] {1,3,5,6};
            int left = 0, right = nums.Length - 1, target = 3;

            while(left <= right) {
                
                int mid = left + (right - left) / 2;                

                if(target == nums[mid])     //check if target is present at mid
                {
                    found = true;
                    Console.WriteLine("Item " + target + " is at Index " + mid);
                    break;
                }
                else if(target > nums[mid])      //if greater than mid , ignore left half
                {
                    left = mid + 1;
                }
                else                 //if smaller than mid , ignore right half
                {
                    right = mid - 1;
                }        
                
            }

            if(!found)
            {
                Console.WriteLine("Item " + target + " is at Index " + left);   //return the index where it would be
            }
           
        }
    }
}
