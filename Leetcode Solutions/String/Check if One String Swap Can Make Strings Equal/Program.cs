using System;
using System.Text;
using System.Collections. Generic;
using System.Linq;

// You are given two strings s1 and s2 of equal length. A string swap is an operation where you choose two indices in a string (not necessarily different) and swap the characters at these indices.
// Return true if it is possible to make both strings equal by performing at most one string swap on exactly one of the strings. Otherwise, return false.
// Runtime: 76 ms, faster than 62.12% of C# online submissions for Check if One String Swap Can Make Strings Equal.
// Memory Usage: 23.1 MB, less than 59.09% of C# online submissions for Check if One String Swap Can Make Strings Equal.
namespace Check_if_One_String_Swap_Can_Make_Strings_Equal
{
    class Program
    {
        static void Main(string[] args)
        {           
            string s1 = "bank", s2 = "kanb";  //"caa", s2 = "aaz"

            bool flag = false;
            int numOfIndices = 0;   

            Console.WriteLine(s1 + " and " + s2);

            /* Checking if only two chacters within the string are different */

            if(s1.Except(s2).Any())     // check if all letters are the same in both strings
            {
                numOfIndices = -1;
            }
            else
            {
                for(int i = 0; i <= s1.Length-1; i++) 
                {
                    if(s1[i] != s2[i]) // check if possible to perform one string swap
                        numOfIndices++; 
                                                       
                }

            }
           
            flag = (numOfIndices == 0 || numOfIndices == 2) ? true : false;  

            Console.WriteLine("It is \"" + flag + "\" that at most one string swap can be performed on exactly one of the strings.");   
      
        }
    }
}
