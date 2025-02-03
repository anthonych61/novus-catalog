using System;
using System.Collections;

//Given a string S of lowercase letters, a duplicate removal consists of choosing two adjacent and equal letters, and removing them.
//We repeatedly make duplicate removals on S until we no longer can.
//Return the final string after all such duplicate removals have been made. It is guaranteed the answer is unique.
namespace Adjacent_Duplicate_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "azxxzy";    //"aababaab"; //"azxxzy"; //"abbaca"; 
            var ch = s.ToCharArray(); 
            int i = ch.Length-1; 
            Stack stk = new Stack(); // create and intialize new stack
            
            while(i >= 0)
            {
                if(stk.Count == 0 || ch[i] != (char)stk.Peek())
                {  
                    stk.Push(ch[i]); // insert object onto top of stack     
                               
                }
                else
                {
                    stk.Pop();  // remove top object if equal to current character
                }               
                i--;

            }

            while(stk.Count > 0)
            {
                Console.Write(stk.Peek()); // pop and return all objects on the stack
                stk.Pop();
            }
            
            Console.WriteLine();

        }
    }
}
