namespace Find_All_Numbers_Disappeared_in_an_Array;

// Given an array nums of n integers where nums[i] is in the range [1, n], return an array of all the integers in the range [1, n] that do not appear in nums.
class Program
{
    static void Main(string[] args)
    { 
       /* 
        List<int> ls = new List<int>();
        HashSet<int> hs = new HashSet<int>(nums);
        for(int i = 1; i <= nums.Length; i++) {
            if(!hs.Contains(i)) 
                ls.Add(i); 
         }           
       */     
       int[] nums = {4,3,2,7,8,2,3,1};  
       List<int> iList = new List<int>();

       for(int i = 1; i<= nums.Length; i++)
            if(Array.IndexOf(nums, i) == -1)  
               iList.Add(i);

       foreach(var j in iList)
            Console.WriteLine(j);
       
    }
}
