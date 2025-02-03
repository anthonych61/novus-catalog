using System;

// At a lemonade stand, each lemonade costs $5. Customers are standing in a queue to buy from you, and order one at a time (in the order specified by bills). 
// Each customer will only buy one lemonade and pay with either a $5, $10, or $20 bill. You must provide the correct change to each customer so that the net transaction is that the customer pays $5.
// Note that you don't have any change in hand at first.
// Given an integer array bills where bills[i] is the bill the ith customer pays, return true if you can provide every customer with correct change, or false otherwise.
// Complexity Analysis:
// Time Complexity: O(N), where N is the length of bills.
// Space Complexity: O(1).
namespace Lemonade_Change
{
    class Program
    {
        static void Main(string[] args)
        {  
            Boolean flag = true;
            int[] bills = new int[] {5,5,5,10,20}; // {5,5,5,10,5,5,10,20,20,20}; 
            int fiveDollars = 0, tenDollars = 0;      
           
            for(int i = 0; i <= bills.Length-1; i++)
            {                   
                if(bills[i] == 5)   // keep track of $5 bills received
                {
                    fiveDollars++;
                }
                else if(bills[i] == 10)     // keep track of $10 bills received
                {
                    tenDollars++;
                    
                    if(fiveDollars >= 1)
                    {
                        fiveDollars--; // give back $5 change
                    }
                    else
                    {
                        flag = false;
                    }
                    
                }
                else // otherwise
                {                    
                    if(fiveDollars >= 1 && tenDollars >= 1)
                    {
                        fiveDollars--; // give back $5 | $10 change
                        tenDollars--;
                    }
                    else if(fiveDollars >= 3)
                    {
                        fiveDollars-=3; // give back $5 change
                    }
                    else
                    {
                        flag = false;
                    }
                    
                }                     
                               
            }           
            Console.WriteLine(flag);           
          
        }
    }
}
