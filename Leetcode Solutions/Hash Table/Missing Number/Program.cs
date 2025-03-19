namespace Missing_Number;
class Program
{
    // Given an array nums containing n distinct numbers in the range [0, n], return the only number in the range that is missing from the array.
    static void Main(string[] args)
    {
        int[] nums = new int[] { 0,1 };
        Dictionary<int, int> dict = new Dictionary<int, int>();

        for(int i = 0; i <= nums.Length-1; i++) {
            dict.Add(i, nums[i]);
        }
        
        for(int j = 0; j <= nums.Length-1; j++) 
        {
            if(!dict.ContainsValue(j))
            {
                Console.WriteLine(j);
            }
            else 
            {
                Console.WriteLine(nums.Length);
            }  
                      
            break;

        }   
        
    }
}
