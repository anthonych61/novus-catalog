using System;
using System.Collections.Generic;

// Given a positive integer num represented as a string, return the integer num without trailing zeros as a string.

namespace RemoveTrailingZeros
{
    class Program
    {
        static void Main(string[] args)
        {
            //string num = "512301000000000000000000000000000000000000000000000000000000000000000000";
            string num = "94353214300000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000"; 
            
            // Solution #1 
            //int count = num.Length - 1;
            // while (true) {  
            //     if (count == num.LastIndexOf("0")) {
            //         num = num.Substring(0, count);
            //         count--;
            //     }
            //     else { break; }                             
                
            // }
            //Console.WriteLine(num);
            
            // Solution #2
            int i = num.Length - 1;
            while(num[i] == '0') {
                i--;
            }
            Console.WriteLine(num.Substring(0, i + 1));
            
        }

    }
}

