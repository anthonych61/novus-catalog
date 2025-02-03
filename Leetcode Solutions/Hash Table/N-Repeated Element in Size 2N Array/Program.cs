using System;
using System.Collections.Generic;

// In a array A of size 2N, there are N+1 unique elements, and exactly one of these elements is repeated N times.
// Return the element repeated N times.
// Time Complexity: O(N), where N is the length of A
// Space Complexity: O(N)
namespace N_Repeated_Element_in_Size_2N_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = 0;
            int[] A = new int[] {5,1,5,2,5,3,5,4};
            HashSet<int> hs = new HashSet<int>(); //create hashset of integers
            //insert elements into hashset
            for(int i = 0; i <= A.Length-1; i++)
             {
                 if(hs.Contains(A[i]))
                 {
                    result = A[i];
                 }
                 hs.Add(A[i]);
             }
             Console.WriteLine(result);
        }
    }
}
