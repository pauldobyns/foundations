// File: Range.cs

using System;

//Polynomial Evaluator
class TestRange
{
    static void Main()
    {
        //ask the user to input a number in the Console
        Console.Write("Please enter a value for x:");
        //read the number from the Console
        string str = Console.ReadLine();
        //convert the string to a number
        int x = int.Parse(str);
        //evaluate the Polynomial 5*x*x+6
        int iResult = (int)(5 * Math.Pow(x,2) + 6);
        //convert the result to a string
        //write the result to the console
        Console.WriteLine("The calculated value for 5x^2+6 is {0}", iResult);

        Console.ReadLine();
    }
}