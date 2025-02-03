// Given two string arrays word1 and word2, return true if the two arrays represent the same string, and false otherwise.
// A string is represented by an array if the array elements concatenated in order forms the string.
namespace Check_If_Two_String_Arrays_are_Equivalent;

class Program
{
    static void Main(string[] args)
    {
        string[] word1 = {"ab", "c"}, word2 = {"a", "bc"};        
  
        if(string.Join("", word1) == string.Join("", word2))
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
        
    }
}
