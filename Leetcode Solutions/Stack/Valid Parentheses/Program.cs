using System;
using System.Collections;

// Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
// An input string is valid if:
// 1. Open brackets must be closed by the same type of brackets.
// 2. Open brackets must be closed in the correct order.

// Time complexity : O(n) because we simply traverse the given string one character at a time and push and pop operations on a stack take O(1) time.
// Space complexity : O(n) as we push all opening brackets onto the stack and in the worst case, we will end up pushing all the brackets onto the stack. e.g. ((((((((((.
namespace Valid_Parentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "{{}[][[[]]]}";  // "([)]"; 
            Stack stk = new Stack();     // Initialize stack

            for(int i = 0; i <= s.Length-1; i++) {

                if(stk.Count != 0) {

                    // If encounter closing bracket, check element on top of stack. If element on top of stack is an opening bracket (same type), 
                    // then pop it off the stack and continue processing. 
                    char top = (char)stk.Peek();

                    if (top == '(' && s[i] == ')') 
                    {
                         stk.Pop(); 
                    }
                    else if (top == '{' && s[i] =='}') 
                    {
                         stk.Pop();
                    }
                    else if (top == '[' && s[i] == ']') 
                    {
                         stk.Pop();
                    }
                    else 
                    {
                         stk.Push(s[i]); // push bracket onto top of the stack
                    }

                }
                else 
                {
                    stk.Push(s[i]); // push bracket onto top of the stack
                }

            }

            while(stk.Count != 0) // Verify balanced parentheses. If stack contains any elements this is an invalid expression.
            {         
                Console.Write(stk.Peek());
                stk.Pop();
            }

            if(stk.Count == 0) 
            {
                Console.WriteLine(true);
            }
            else 
            {
                Console.WriteLine(false);
            }

        }
    }
}
