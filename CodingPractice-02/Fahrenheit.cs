using System;
using System.Collections.Generic;
using System.Text;

public struct Fahrenheit
{
    public double Degrees;

    public Fahrenheit(double degrees)
    {
        Degrees = degrees;
    }

    public static explicit operator Celsius(Fahrenheit degrees)
    {
        return new Celsius((degrees.Degrees - 32) / 9 * 5);
    }

    public override string ToString()
    {
        return $"{Degrees}°F";
    }
}