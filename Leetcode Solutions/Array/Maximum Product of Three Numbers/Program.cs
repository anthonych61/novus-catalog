using System.Globalization;
using System.Linq.Expressions;

// Given an integer array nums, find three numbers whose product is maximum and return the maximum product.

namespace Maximum_Product_of_Three_Numbers;
class Program
{
    static void Main(string[] args)
    {           
        int[] nums = {-2,20,99,-5,-3}; //{-4,-3,-2,-1,60}; //{-6,-2,1,2,3,7}; //{-100,-2,-3,1};   
        int length = nums.Length; 

        Array.Sort(nums);
        
        /* for(int i = 0; i < nums.Length; i++) 
            Console.WriteLine(nums[i]); */
 
        if((nums[length-1] > 0) && (nums[0] < 0))
        {
            int num1 = nums[0] * nums[1] * nums[length-1];
            int num2 = nums[length-3] * nums[length-2] * nums[length-1];

            if(num1 < num2)
            {
                Console.WriteLine("sum : " + num2);
            }
            else
            {
                Console.WriteLine("sum : " + num1);
            }

        }
        else
        {
            int sum = 1;
            for(int i = length-1; i >= length-3; i--) 
            {
                sum *= nums[i];
            }

            Console.WriteLine("sum : " + sum);   
        }                
    
    }
}
