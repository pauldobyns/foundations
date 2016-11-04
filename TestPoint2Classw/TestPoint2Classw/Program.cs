using System;
class Point
{
    private int X;
    private int Y;

    public Point(int x, int y)
    {
        X = x;
        Y = y;
        
    }

    public int GetX()
    {
        return X;
    }

    public int GetY()
    {
        return Y;
    }
}

class TestPoint2Class
{
    static void Main()
    {
        Point pt = new Point(10, 20);

        Console.WriteLine("{0},{1}", pt.GetX(), pt.GetY());
    }
}