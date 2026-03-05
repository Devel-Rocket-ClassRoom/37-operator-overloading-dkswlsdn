using System;
using System.Collections.Generic;
using System.Text;

public struct Vector2
{
    public int X;
    public int Y;

    public Vector2(int x, int y)
    {
        X = x; Y = y; 
    }


    public static Vector2 operator +(Vector2 v1, Vector2 v2)
    {
        return new Vector2(v1.X + v2.X, v1.Y + v2.Y);
    }

    public override string ToString()
    {
        return $"({X}, {Y})";
    }
}