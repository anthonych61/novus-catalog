
namespace _2942._Find_Words_Containing_Character;

// You are given a 0-indexed array of strings words and a character x.
// Return an array of indices representing the words that contain the character x.
// Note that the returned array may be in any order.
class Program
{
    static void Main(string[] args)
    {
        string[] words = {"leet","code"};
        char x = 'e';        
       
        var li = new List<int>();
        for(int i = 0; i<= words.Length-1; i++) 
            if(words[i].Contains(x.ToString())) 
                li.Add(i);

        // loop through list
        foreach(var item in li)
            Console.Write(item + " ");
       
        Console.WriteLine();
    }
}
