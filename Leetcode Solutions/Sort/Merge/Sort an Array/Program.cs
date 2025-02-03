using System;

//Given an array of integers nums, sort the array in ascending order.
//Time complexity: O(n Log n)
//Auxilary Space: O(n)
namespace Sort_an_Array
{
    class Program
    {
        //function to merge two halves arr[start ... mid]
        //and arr[mid+1...end]
        void merge(int[] arr, int start, int mid, int end)
        {
            //create temp array
            int[] tmp = new int[end - start + 1];
            int i = start, j = mid + 1, k = 0;
            //traverse both arrays add smaller of both elements to tmp
            while(i <= mid && j <= end) {

                if(arr[i] <= arr[j]) 
                {
                    tmp[k] = arr[i];
                    i++;
                }
                else
                {
                    tmp[k] = arr[j];
                    j++;
                }
                k++;
            } 
            //add elements left in first interval
            while(i <= mid) {    
                tmp[k] = arr[i];
                k++;
                i++;
            }
            //add elements left in second interval
            while(j <= end) {    
                tmp[k] = arr[j];
                k++;
                j++;
            }
            //copy tmp to the orignal interval
            for(i = start; i <= end; i++)
            {
                arr[i] = tmp[i - start];
            }
        }

        void mergeSort(int[] arr, int start, int end)
        {
            if(start < end)
            {
                int mid = (start + end) / 2;
                mergeSort(arr, start, mid);
                mergeSort(arr, mid+1, end);
                merge(arr, start, mid, end);
            }
        }

        static void Main(string[] args)
        {
            int[] nums = new int[]{5,1,1,2,0,0};

            Program obj = new Program();
            obj.mergeSort(nums, 0, nums.Length-1);

            for(int  i = 0; i <= nums.Length-1; i++)
                Console.Write(nums[i] + " ");

            Console.WriteLine();
        }
    }
}
