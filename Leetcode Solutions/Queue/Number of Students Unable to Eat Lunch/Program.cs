using System;
using System.Collections.Generic;
// The school cafeteria offers circular and square sandwiches at lunch break, referred to by numbers 0 and 1 respectively. All students stand in a queue. 
// Each student either prefers square or circular sandwiches. The number of sandwiches in the cafeteria is equal to the number of students. 

// The sandwiches are placed in a stack. At each step:
// -If the student at the front of the queue prefers the sandwich on the top of the stack, they will take it and leave the queue.
// -Otherwise, they will leave it and go to the queue's end.

// This continues until none of the queue students want to take the top sandwich and are thus unable to eat.
// You are given two integer arrays students and sandwiches where sandwiches[i] is the type of the i​​​​​​th sandwich in the stack (i = 0 is the top of the stack) and students[j] is the preference of 
// the j​​​​​​th student in the initial queue (j = 0 is the front of the queue). 
// Return the number of students that are unable to eat.
namespace Number_of_Students_Unable_to_Eat_Lunch
{
    class Program
    {
        static void Main(string[] args)
        {  
            int i = 0;
            int[] students = new int[] {1,1,1,0,0,1}; // {1,1,0,0}; 
            int[] sandwiches = new int[] {1,0,0,0,1,1};  // {0,1,0,1};         
            Queue<int> queue = new Queue<int>();            
                      
            for(int j = 0; j <= students.Length-1; j++) 
               queue.Enqueue(students[j]);

            int count = queue.Count+sandwiches.Length;

            while(count-- > 0 && queue.Count != 0)
            {
                if(queue.Peek() == sandwiches[i])   
                {
                    queue.Dequeue();
                    i++;
                }
                else
                {
                    int top = queue.Dequeue();
                    queue.Enqueue(top);
                }
                       
            }

            Console.WriteLine("Output : " + queue.Count);

        }
    }
}
