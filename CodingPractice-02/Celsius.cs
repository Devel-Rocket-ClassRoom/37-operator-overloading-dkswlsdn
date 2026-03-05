using System;
using System.Collections.Generic;
using System.Text;

public struct Celsius
{
    public double Degrees;

    public Celsius(double degrees)
    {
        Degrees = degrees; 
    }

    public static explicit operator Fahrenheit(Celsius celsius)
    {
        return new Fahrenheit(celsius.Degrees / 5 * 9 + 32);
    }

    public override string ToString()
    {
        return $"{Degrees}°C";
    }
}