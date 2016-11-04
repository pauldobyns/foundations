using System;

namespace array_ex1
{
    class exercise
    {
        static void Main()
        {
            int[] aNum = new int[] { 0, 2, 5, 100, -1, 4, 8, -5 };
            int Min = aNum[0];
            int Max = aNum[0];
            foreach (int x in aNum)
            {
                if (x < Min)
                {
                    Min = x;
                }
                if (x > Max)
                {
                    Max = x;
                }
            }
            Console.WriteLine("The minimum value is {0} and the maximum is {1}", Min, Max);
            Console.ReadLine();
        }
    }
}
