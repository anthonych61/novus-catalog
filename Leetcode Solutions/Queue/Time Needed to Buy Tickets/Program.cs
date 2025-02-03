using System;
using System.Collections.Generic;

// There are n people in a line queuing to buy tickets, where the 0th person is at the front of the line and the (n - 1)th person is at the back of the line.
// You are given a 0-indexed integer array tickets of length n where the number of tickets that the ith person would like to buy is tickets[i].
// Each person takes exactly 1 second to buy a ticket. A person can only buy 1 ticket at a time and has to go back to the end of the line (which happens instantaneously) in order to buy more tickets. 
// If a person does not have any tickets left to buy, the person will leave the line.
// Return the time taken for the person at position k (0-indexed) to finish buying tickets.
namespace Time_Needed_to_Buy_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            int seconds = 0, counter = 0, k = 3; 
            int[] tickets = new int[] {84,49,5,24,70,77,87,8}; 
            Queue<int> queue = new Queue<int>();
            
            for(int j = 0; j < tickets.Length; j++)
                queue.Enqueue(tickets[j]);

            counter = k;
           
            while(queue.Count > 0) 
            {   
                int top = queue.Dequeue(); // remove and 
                // return object at the beginning of the queue
                
                if(counter == 0) 
                {  
                    if(top == 1) 
                    {
                        seconds = seconds+1; 
                        break;                        
                    }
                    else
                    {
                        top = top-1; // decrement by 1
                        if(top > 0)
                            queue.Enqueue(top); // add item into queue

                        counter = queue.Count;  // reset counter
                    }

                }
                else
                {
                    top = top-1;
                    if(top > 0)
                        queue.Enqueue(top);                    
                } 

                counter--;
                seconds++;   
            }

            Console.WriteLine("Output : " + seconds);
          
        }
    }
}
