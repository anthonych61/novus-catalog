using System.Diagnostics.Contracts;
using System.Numerics;

namespace Plus_One;
// You are given a large integer represented as an integer array digits, where each digits[i] is the ith digit of the integer. 
// The digits are ordered from most significant to least significant in left-to-right order. The large integer does not contain any leading 0's.
// Increment the large integer by one and return the resulting array of digits.
class Program
{
    static void Main(string[] args)
    {
       int[] digits = {7,2,8,5,0,9,1,2,9,5,3,6,6,7,3,2,8,4,3,7,9,5,7,7,4,7,4,9,4,7,0,1,1,1,7,4,0,0,6}; 
       var strInt = string.Join("", digits);  
       var result =  BigInteger.Parse(strInt) + 1;    
       Array.Resize(ref digits, result.ToString().Length);        
       var i = 0;

       while(result > 0) 
        {
            var d = result % 10;
            digits[i++] = (int)d;
            result = result / 10;            
        }

        Array.Reverse(digits);

        for(int j = 0; j <= digits.Length-1; j++)
            Console.Write(digits[j]);
   
        Console.WriteLine();

     }
}
