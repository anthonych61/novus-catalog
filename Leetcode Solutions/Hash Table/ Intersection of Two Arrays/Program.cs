using System;
using System.Collections.Generic;

// Given two integer arrays nums1 and nums2, return an array of their intersection. Each element in the result must be unique and you may return the result in any order.
namespace Intersection_of_Two_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            int[] nums1 = {4,9,5}, nums2 = {9,4,9,8,4};            
            Dictionary <int,int> mp = new Dictionary<int,int>();
            for(int i = 0; i <= nums1.Length-1; i++) {
                if(!mp.ContainsKey(nums1[i]))   // determine whether dictionary contains specified key
                    mp.Add(nums1[i],0);
                mp[nums1[i]]++;
            }

            for(int j = 0; j <= nums2.Length-1; j++) {
                if(mp.ContainsKey(nums2[j])) {   mp.Remove(nums2[j]);   //remove value with specified key from dictionary
                    list.Add(nums2[j]); //add object to the end of the list
                } 
            }  

            foreach(var index in list)
                  Console.WriteLine(index);

        }
    }
}
