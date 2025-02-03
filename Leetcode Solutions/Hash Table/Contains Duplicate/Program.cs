using System;

//Given an array of integers, find if the array contains any duplicates. 
//Your function should return true if any value appears at least twice in the array, and it should return false if every element is distinct.
namespace Contains_Duplicate
{
    class Program
    {
        static void Main(string[] args)
        {   
            bool flag = false;
            int[] num = {1, 2, 3, 9, 3};   

            Array.Sort(num);

            for(int i = 0; i < num.Length-1; i++)
            {
                if(num[i] == num[i+1])
                    flag = true;
                                           
            }  

            Console.WriteLine(flag);

        }
    }
}
