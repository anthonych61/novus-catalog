using System;
using System.Collections.Generic;

//You are given an integer array nums. The unique elements of an array are the elements that appear exactly once in the array.
//Return the sum of all the unique elements of nums.
namespace Sum_of_Unique_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[] nums = new int[] {1,2,3,2};
            Dictionary<int,int> dict = new Dictionary<int,int>();

            for(int i = 0; i <= nums.Length-1; i++)
            {
                if(dict.ContainsKey(nums[i]))
                {
                    var val = dict[nums[i]];
                    dict.Remove(nums[i]);
                    dict.Add(nums[i], val+1);
                }
                else
                {
                    dict.Add(nums[i], 1);
                }    

            }

            foreach (KeyValuePair<int,int> kv in dict)
            {
                if(kv.Value == 1)
                {
                    sum += kv.Key;
                }
            }
            
            Console.WriteLine(sum);

        }
    }
}
