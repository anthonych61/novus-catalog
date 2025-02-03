using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

// A bracket is considered to be any one of the following characters: (, ), {, }, [, or ].
// Two brackets are considered to be a matched pair if the an opening bracket (i.e., (, [, or {) occurs to the left of a closing bracket (i.e., ), ], or }) of the exact same type. There are three types of matched pairs of brackets: [], {}, and ().
// A matching pair of brackets is not balanced if the set of brackets it encloses are not matched. For example, {[(])} is not balanced because the contents in between { and } are not balanced. The pair of square brackets encloses a single, unbalanced opening bracket, (, and the pair of parentheses encloses a single, unbalanced closing square bracket, ].
// By this logic, we say a sequence of brackets is balanced if the following conditions are met:
// It contains no unmatched brackets.
// The subset of brackets enclosed within the confines of a matched pair of brackets is also a matched pair of brackets.
// Given  strings of brackets, determine whether each sequence of brackets is balanced. If a string is balanced, return YES. Otherwise, return NO.
// Function Description
// Complete the function isBalanced in the editor below.
// isBalanced has the following parameter(s):
// string s: a string of brackets
// Returns
// string: either YES or NO

class Result
{
    /*
     * Complete the 'isBalanced' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string isBalanced(string s)
    {
        Stack stk = new Stack();  // intialize stack
           
        for(int i = 0; i <= s.Length-1; i++)
        {
            if(stk.Count == 0)
            {
                stk.Push(s[i]);
            } 
            else
            {
                // If encounter closing bracket, check element on top of stack. 
                // If element on top of stack is an opening bracket (same type), 
                // then pop it off the stack and continue processing. 
                char top = (char)stk.Peek();
                
                if(top == '(' && s[i] == ')')
                {
                    stk.Pop();
                }
                else if(top == '{' && s[i] == '}')
                {
                    stk.Pop();
                }
                else if(top == '[' && s[i] == ']')
                {
                    stk.Pop();
                }
                else
                {
                    stk.Push(s[i]); // push bracket onto top of the stack
                }
                
            }
            
        }   

        // Verify balanced parentheses. 
        // If stack contains any elements this is an invalid expression.              
        return (stk.Count == 0)? "YES" : "NO";
    }
    
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int t = Convert.ToInt32(Console.ReadLine().Trim());

        for (int tItr = 0; tItr < t; tItr++)
        {
            string s = Console.ReadLine();

            string result = Result.isBalanced(s);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
