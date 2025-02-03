namespace Add_Digits;
// Given an integer num, repeatedly add all its digits until the result has only one digit, and return it.
class Program
{
    static void Main(string[] args)
    {  
        int sum = 0, result = 38;

        while(true)
        {
            var d = result % 10;
            sum += d; 
            result = result / 10; 

           if(result == 0)
           {            
                result = sum;

                if(sum < 10)
                {
                   Console.WriteLine(sum);
                   break;
                }

                sum = 0;                
           }
               
        }

    }
}
