using System;
using System.Collections.Generic;
using System.Text;

public struct Celsius
{
    public double Cel;


    public Celsius(double cel)
    {
        Cel = cel; 
    }


    public static implicit operator double(Celsius celsius)
    {
        return celsius.Cel;
    }

    public static implicit operator Celsius(double celsius)
    {
        return new Celsius(celsius);
    }
}