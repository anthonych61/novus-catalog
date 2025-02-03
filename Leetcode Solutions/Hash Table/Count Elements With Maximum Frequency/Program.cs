using System.Globalization;
using System.Linq;

// You are given an array nums consisting of positive integers.
// Return the total frequencies of elements in nums such that those elements all have the maximum frequency.
// The frequency of an element is the number of occurrences of that element in the array.
namespace Count_Elements_With_Maximum_Frequency;
class Program
{
    static void Main(string[] args)
    {        
        /*
        int sum = 0;
        int[] nums = {1,2,2,3,1,4}; //{1,2,3,4,5}; 
        Dictionary<int, int> dict = new Dictionary<int, int>();
        for(int i = 0; i <= nums.Length - 1; i++)
        {
            if(!dict.ContainsKey(nums[i]))
                dict.Add(nums[i], 0);
            dict[nums[i]]++;
        }

        var integers = dict.OrderByDescending(k => k.Value).ToArray();
      
        for(int j = 0; j <= integers.Length - 1; j++)
            if(integers[j].Value == integers[0].Value)
                sum += integers[j].Value;
 
        Console.WriteLine("Maximum Frequency : " + sum);
        */

        int count = 0;
        int maxFrequency = 0;
        int[] nums  = {1,2,2,3,1,4}; //{1,2,3,4,5}; //
        int[] frequencyArray = new int [101];

        for(int i = 0; i <= nums.Length-1; i++)
            frequencyArray[nums[i]]++;

        for(int j = 0; j <= frequencyArray.Length-1; j++)
            maxFrequency = Math.Max(maxFrequency,frequencyArray[j]);

        for(int n = 0; n <= frequencyArray.Length-1; n++)
            if(frequencyArray[n] == maxFrequency)
                count++;

        Console.WriteLine("Maximum Frequency : " + maxFrequency*count);       
       
    }
}
