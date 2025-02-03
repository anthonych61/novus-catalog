using System;
using System.Collections;

// Given a string s of lower and upper case English letters.
// A good string is a string which doesn't have two adjacent characters s[i] and s[i + 1] where:
// 0 <= i <= s.length - 2
// s[i] is a lower-case letter and s[i + 1] is the same letter but in upper-case or vice-versa.
// To make the string good, you can choose two adjacent characters that make the string bad and remove them. You can keep doing this until the string becomes good.
// Return the string after making it good. The answer is guaranteed to be unique under the given constraints.
// Notice that an empty string is also good.
namespace Make_The_String_Great
{
    class Program
    {
        static void Main(string[] args)
        {
            string newStr = "", s = "kkdsFuqUfSDKK"; //"leEeetcode"; //"abBAcC";  
            Stack stk = new Stack();
            Stack reverse = new Stack();
        
            Console.WriteLine("Original string: " + s);

            for(int i = 0; i <= s.Length-1; i++)
            {
                if(stk.Count == 0) // push first element onto stack
                {
                  stk.Push(s[i]);  
                }
                else
                { 
                    char top = Convert.ToChar(stk.Peek());

                    if (Char.IsUpper(top) && Char.IsLower(s[i]) || Char.IsLower(top) && Char.IsUpper(s[i])) // check for lower and upper case adjacent characters s[i] & s[i+1]
                    {
                       if(String.Equals(top.ToString(), s[i].ToString(), StringComparison.OrdinalIgnoreCase)) // verify equality
                       {
                            stk.Pop(); // pop stack
                       }
                       else
                       {
                           stk.Push(s[i]); // otherwise push element onto stack
                       }

                    }   
                    else 
                    {
                        stk.Push(s[i]); // if not upper or lowercase character push element onto stack
                    }

                }

            }

            while(stk.Count != 0) {  // reverse stack using another stack
                reverse.Push(stk.Pop());
            }

            foreach(char c in reverse) { // build string
                newStr += c;
            }

            Console.WriteLine("Modified string: " + newStr);
            
        }
    }
}
