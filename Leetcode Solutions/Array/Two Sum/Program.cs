using System;

//Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
//You may assume that each input would have exactly one solution, and you may not use the same element twice.
//You can return the answer in any order.
namespace twoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int target = 6; 

            int[] array = {3,2,4};                
           
            for (int i = 0; i <= array.Length-1; i++)
            {
                for(int j = i+1; j <= array.Length-1; j++)
                {
                    if(array[j] == target - array[i])
                        Console.WriteLine(j + " " + i);
                }

            }           
           
        }
    }
}
