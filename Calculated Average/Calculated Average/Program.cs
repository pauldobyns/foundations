// Session 5 - In Class Exercise No. 1
// Write a program that calculates the average of numbers given by the user.

using System;

class Average
{
    static void Main()
    {
        float fsum = 0.0f;
        float favg;
        Console.WriteLine("Please enter the count of your set");
        string strcount = Console.ReadLine();
        int numcount = int.Parse(strcount);
        for (int x = 1; x <= numcount; x++)
        {
            Console.Write("Please enter number {0} of {1}:", x, numcount);
            string strnum = Console.ReadLine();
            float n = float.Parse(strnum);
            fsum = fsum + n;
        }
        favg = fsum / numcount;
        Console.WriteLine("The average of the given numbers is {0}", favg);
        Console.ReadLine();
    }

}

