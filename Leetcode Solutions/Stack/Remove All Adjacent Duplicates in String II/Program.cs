using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

// You are given a string s and an integer k, a k duplicate removal consists of choosing k adjacent and equal letters from s and removing them, causing the left and the right side of the deleted substring to concatenate together.
// We repeatedly make k duplicate removals on s until we no longer can.
// Return the final string after all such duplicate removals have been made. It is guaranteed that the answer is unique.
// Time Complexity: O(N)
// Auxilairy Space: O(N)
namespace Remove_All_Adjacent_Duplicates_in_String_II
{
    class Program
    {
        static void Main(string[] args)
        {
           int j = 1, k = 4; 
           string s = "yfttttfbbbbnnnnffbgffffgbbbbgssssgthyyyy"; //"deeedbbcccbdaa" //"abcd" //"pbbcggttciiippooaais"
           StringBuilder sb = new StringBuilder();
           Stack<Pair<char,int>>stk =  new Stack<Pair<char,int>>();

           Console.WriteLine("Original : " + s);   
           
            for(int i = 0; i <= s.Length -1; i++) 
            {  
                if(stk.Count != 0  && stk.Peek().ch == s[i]) // compare character with topmost element on stack
                {   
                    stk.Push(new Pair<char,int>(s[i], stk.Peek().freq+1)); // store equal characters as pair, keep track of count for current character
                    
                    if(stk.Peek().freq == k)       
                    {
                        while(j <= k) {  // pop adjacent k elements from stack
                            stk.Pop(); 
                            j++;                           
                        }
                        j = 1;  // reset counter 
                                 
                    } 
                                    
                }
                else
                {               
                   stk.Push(new Pair<char,int>(s[i],1));  
                }                   
                                                          
            }

           Console.Write("Changed String : " );

           while(stk.Count != 0)
           {
               sb.Append(stk.Peek().ch);
               stk.Pop();
           }

           string newStr = new string(sb.ToString().Reverse().ToArray());
           Console.WriteLine(newStr);
           Console.WriteLine();           

        }
     
        private class Pair <u,v>
        {
            public u ch;
            public v freq;
            public Pair (u ch, v freq)
            {
                this.ch = ch;
                this.freq = freq;
            }

        }
              
    }
}
