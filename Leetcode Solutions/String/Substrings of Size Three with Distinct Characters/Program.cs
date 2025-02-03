using System;
using System.Collections.Generic;

//A string is good if there are no repeated characters.
//Given a string s​​​​​, return the number of good substrings of length three in s​​​​​​.
//Note that if there are multiple occurrences of the same substring, every occurrence should be counted.
//A substring is a contiguous sequence of characters in a string.
namespace Substrings_of_Size_Three_with_Distinct_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            string s = "aababcabc";
            HashSet<char> hs = new HashSet<char>(); //creating HashSet of characters

            for(int i = 0; i <= s.Length-1; i++)
            {
                if(s.Substring(i).Length >= 3)
                { 
                    var wrd = s.Substring(i,3);
                    Console.WriteLine(wrd);

                    for(int j = 0; j <= wrd.Length-1; j++)
                    {
                        //if already present in HashSet, then duplicate found
                        if(hs.Contains(wrd[j]))
                        {
                            count--; //do not include wrd containing the duplicate
                            break;
                        }
                        //add item to HashSet
                        hs.Add(wrd[j]);

                    }

                    hs.Clear(); //removing all elements from HashSet
                    count++;
                   
                }                                                         
            }

            Console.WriteLine("Number of good substrings with no repeated characters: " + count);

        }
    }
}
