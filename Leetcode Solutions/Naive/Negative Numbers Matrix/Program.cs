using System;

//Given a m * n matrix grid which is sorted in non-increasing order both row-wise and column-wise. 
//Return the number of negative numbers in grid.
//Reference - https://www.geeksforgeeks.org/count-negative-numbers-in-a-column-wise-row-wise-sorted-matrix/
//Time complexity: O(n*m) - when all #s are negative in matrix
namespace Negative_Numbers_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int [,] grid  = new int[,] { { 4, 3, 2, -1}, { 3, 2, 1, -1 }, { 1, 1, -1, -2 }, { -1, -1, -2, -3 } };

            for(int i = 0; i < grid.GetLength(0); i++)
            {
                for(int j = 0; j < grid.GetLength(1); j++)
                {
                    if(grid[i,j] < 0)
                        count++;
                        
                }
               
            }
            Console.WriteLine(count);
           
        }
    }
}
