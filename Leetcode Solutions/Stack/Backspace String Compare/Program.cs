using System;
using System.Collections;
using System.Text;

// Given two strings s and t, return true if they are equal when both are typed into empty text editors. '#' means a backspace character.
// Note that after backspacing an empty text, the text will continue empty.
namespace Backspace_String_Compare
{
    class Program
    {
        static void Main(string[] args)
        {            
            Stack stk1 = new Stack();       // declare variables
            Stack stk2 = new Stack();
        
            string t = "ab#c", s = "ad#c", str1 = "", str2 = "";
            
            Console.WriteLine(t + "\n" + s);
       
            for (int i = 0; i <= t.Length-1; i++) {
                
                if (t[i] == '#')    // check if'#' character
                {
                    if (stk1.Count != 0)    // pop stack if not empty to backspace/remove character
                        stk1.Pop();
                }
                else 
                {
                    stk1.Push(t[i]);  // push element onto stack
                }                   

            }  

            for (int i = 0; i <= s.Length-1; i++) { // do same for 's'
                
                if (s[i] == '#')
                {
                    if (stk2.Count != 0)
                        stk2.Pop();
                }
                else 
                {
                    stk2.Push(s[i]);
                }                   

            }     

            while(stk1.Count != 0)      // build string
            {                
                str1 += stk1.Peek();
                stk1.Pop();  
            }    

            while(stk2.Count != 0)      // build string
            {                
                str2 += stk2.Peek();
                stk2.Pop();  
            }      
            
            if(str1.Equals(str2))       // check equality
            {
                Console.WriteLine(str1 +  " equals " + str2);
            }
            else
            {
                Console.WriteLine(str1 +  " does not equal " + str2);
            }
           
        }
       
    }
}
