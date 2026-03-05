using System;
using System.Collections.Generic;
using System.Text;

public struct Money
{
    public int Value;
    public string Unit;


    public Money(int value, string unit)
    {
        Value = value;
        Unit = unit;
    }


    public static bool operator ==(Money left, Money right)
    {
        if (left.Unit != right.Unit)
        {
            return false;
        }

        return left.Value == right.Value;
    }

    public static bool operator !=(Money left, Money right)
    {
        return !(left == right);
    }

    public static bool operator <(Money left, Money right)
    {
        if (right.Unit != left.Unit)
        {
            return false;
        }

        return left.Value < right.Value;
    }

    public static bool operator >(Money left, Money right)
    {
        return !(left < right);
    }

    public override bool Equals(object obj)
    {
        if (obj is Money other)
        {
            return this == other;
        }

        return false;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Value, Unit);
    }

}