using System;

namespace HomeWork3
{
    class Program
    {
        static void Main()
        {
            //Declare Variables
            string StrFact;
            uint IntFact;
            uint x;
            uint Result = 1;
            //Get user input
            Console.Write("Please enter an integer to return the factorial: ");
            StrFact = Console.ReadLine();
            //Convert User input
            IntFact = uint.Parse(StrFact);
            //Calculate the result
            for (x = 2; x<=IntFact; x++)
            {
                if (x > IntFact)
                {
                    break;
                }
                Result = x * Result;
            }
            //print result
            Console.WriteLine("{0}! = {1}", IntFact, Result);
            //hold console
            Console.ReadLine();
        }
    }
}
