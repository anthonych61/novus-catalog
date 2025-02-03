// Given two strings needle and haystack, return the index of the first occurrence of needle in haystack, or -1 if needle is not part of haystack.
namespace Find_the_Index_of_the_First_Occurrence_in_a_String;

class Program
{
    static void Main(string[] args)
    {
        string haystack = "sadbutsad", needle = "sad";
        int index = haystack.IndexOf(needle, 0);
        Console.WriteLine(index);
    }
}
