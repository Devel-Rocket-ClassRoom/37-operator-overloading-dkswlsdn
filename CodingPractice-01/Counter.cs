using System;
using System.Collections.Generic;
using System.Text;

public struct Counter
{
    public int Value;

    public Counter(int count)
    {
        Value = count; 
    }


    public static Counter operator -(Counter counter)
    {
        return new Counter(-counter.Value);
    }

    public static Counter operator ++(Counter counter)
    {
        return new Counter(++counter.Value);
    }

    public override string ToString()
    {
        return Value.ToString();
    }
}