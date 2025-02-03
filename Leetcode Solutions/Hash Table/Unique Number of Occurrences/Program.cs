using System;
using System.Collections.Generic;
using System.Linq;

//Given an array of integers arr, write a function that returns true if and only if the number of occurrences of each value in the array is unique.
namespace Unique_Number_of_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            int[] arr = new int[] {-3,0,1,-3,1,1,1,-3,10,0};
            Dictionary<int,int> dict = new Dictionary<int,int>();
            HashSet<int> hs = new HashSet<int>();
           
            for(int i = 0; i <= arr.Length-1; i++)
            {
                if(!dict.ContainsKey(arr[i]))
                    dict.Add(arr[i],0);
                
                dict[arr[i]]++;
                
            }

            foreach(KeyValuePair<int,int> kv in dict)
            {
                if(hs.Contains(kv.Value)) // check if number occurences of any value is unique
                    flag = false;
                    
                hs.Add(kv.Value);
                               
            }
            Console.WriteLine(flag);
           
        }
    }
}
