using System;
using System.Collections.Generic;

//Given two integer arrays nums1 and nums2, return an array of their intersection. 
//Each element in the result must appear as many times as it shows in both arrays and you may return the result in any order.
namespace Intersection_of_Two_Arrays_II
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            int[] nums1 = {1,2,2,1}, nums2 = {2,2};
            Dictionary<int,int> mp = new Dictionary<int,int>();
            for(int i = 0; i <= nums1.Length-1; i++) {
                if(!mp.ContainsKey(nums1[i])) // determine whether dictionary contains specified key
                    mp.Add(nums1[i],0);
                mp[nums1[i]]++;
            }

            for(int j = 0; j <= nums2.Length-1; j++) {
                if(mp.ContainsKey(nums2[j])) { 
                    if(mp[nums2[j]] > 0)
                        list.Add(nums2[j]); // add object to list if present in both arrays
                    mp[nums2[j]]--;
                }
            }
            
           foreach(var li in list)
                Console.WriteLine(li); // print list of emeleements
                

        }
    }
}
