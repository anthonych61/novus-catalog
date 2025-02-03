using System;
using System.Collections.Generic;
using System.Linq;

//Given a list of prices for the flavors of ice cream, select the two that will cost all of the money they have.
//For example, they have m = 6 to spend and there are flavors costing cost = [1,3,4,5,6]. 
//The two flavors costing 1  and 5 meet the criteria. Using 1-based indexing, they are at indices 1 and 4.
//Time Complexity: O(n) - As whole array is needed to be traversed only once
//Auxiliary Space: O(n) - Dictionary is being used to store array elements.
namespace Ice_Cream_Parlor
{
    class Program
    {
        static void Main(string[] args)
        { 
            int m = 6;
            int[] arr = new int[] {1,3,4,5,6}; 
            Dictionary<int,int> mp = new Dictionary<int,int>();

            Console.WriteLine("m = " + m);

            for(int i = 0; i <= arr.Length-1; i++)
            {
                int temp = m - arr[i];

                if(mp.ContainsKey(temp)) 
                {
                    Console.Write("Pair: " + (mp[temp] + 1) + ", " + (i + 1));
                }
                
                if(!mp.ContainsKey(arr[i]))
                {
                    mp.Add(arr[i], i); 
                }                               

            }

            Console.WriteLine();
            
        }
    }
}
