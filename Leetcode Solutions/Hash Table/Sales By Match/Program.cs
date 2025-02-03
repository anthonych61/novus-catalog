using System;
using System.Collections.Generic;

//There is a large pile of socks that must be paired by color. 
//Given an array of integers representing the color of each sock, determine how many pairs of socks with matching colors there are.
namespace Sales_By_Match
{
    class Program
    {
        static void Main(string[] args)
        {
            var pairs = 0;
            List<int> li = new List<int> {1,2,1,2,1,3,2};
            Dictionary<int,int> dict = new Dictionary<int,int>();

            for(int i = 0; i<= li.Count-1; i++)
            {
                if(dict.ContainsKey(li[i]))
                {
                    var val = dict[li[i]];
                    dict.Remove(li[i]);
                    dict.Add(li[i], val + 1);
                }
                else
                {
                    dict.Add(li[i], 1);
                }

            }
            
            foreach(KeyValuePair<int, int> entry in dict)
            {
                if(entry.Value > 1)
                    pairs += entry.Value/2;             
            }

            Console.WriteLine(pairs);

        }
    }
}
