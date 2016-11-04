using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    class Program
    {
        static void Main()
        {
            //Declare variables
            uint i;
            uint InputInt;
            string Input;
            uint Result = 1;
            //get user input
            Console.Write("Enter a number: ");
            Input = Console.ReadLine();
            //convert user input
            InputInt = uint.Parse(Input);
            //loop from 1 to input integer
            for (i = 1; i <= InputInt; i++)
            {
                //calculate factorial
                Result = Result * i;
                //write result
                Console.WriteLine("{0}! = {1, 10}", i, Result);
                //Console.WriteLine("{0}! = {1}", i, Result);
                //break loop if i > InputInt
                if (i > InputInt)
                {
                    break;
                }
            }
            //Hold Console
            Console.ReadLine();
        }
    }
}
