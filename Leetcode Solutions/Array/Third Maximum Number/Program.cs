using System.Diagnostics.Metrics;
using System.Runtime.CompilerServices;
using Microsoft.Win32.SafeHandles;

/* Given an integer array nums, return the third distinct maximum number in this array. If the third maximum does not exist, return the maximum number. */
namespace Third_Maximum_Number;
class Program
{
    static void Main(string[] args)
    {
        int[] nums = new int[]{2,2,3,1}; 
        HashSet<int> hs = new HashSet<int>(nums.OrderByDescending(i=>i));  
        nums = new int[hs.Count];
        hs.CopyTo(nums);

        if(hs.Count == 1)
        {
            Console.WriteLine(nums[0]);
        }
        else if(hs.Count < 3)
        {
           Console.WriteLine(Math.Max(nums[0], nums[1]));
        }
        else
        {             
           Console.WriteLine(nums[2]);            
        }
   
    }
}
