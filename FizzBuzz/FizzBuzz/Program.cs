using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzzer fb = new FizzBuzzer();
            for (int i = 0; i < 101; i++)
            {
                Console.WriteLine(fb.FizzBuzz(i));
            }
            Console.ReadKey();
        }
    }

    public class FizzBuzzer
    {
        public string FizzBuzz(int input)
        {
            string result = string.Empty;
            if (input % 3 == 0)
            {
                result = "Fizz";                //If Devisable by 3, result is equal to "Fizz"
            }
            if (input % 5 == 0)
            {
                result += "Buzz";               //If Devisable by `5, result is equal to "Buzz"
            }
            if (result == string.Empty)
            {
                result = input.ToString();      //Stringify the result if the value is empty
            }
            //return "1";  
            return result;                      //returns result
        }
    }
}
