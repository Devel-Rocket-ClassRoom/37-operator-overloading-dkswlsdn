using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

public struct GameTime
{
    public int Hours;
    public int Minutes;
    public int Seconds;


    public GameTime(int hours, int minutes, int seconds)
    {
        if (seconds >= 60)
        {
            minutes += seconds / 60;
            seconds %= 60;
        }
        if (minutes >= 60)
        {
            hours += minutes / 60;
            minutes %= 60;
        }

        Hours = hours;
        Minutes = minutes;
        Seconds = seconds;
    }

    public int GetTotalSeconds()
    {
        return Hours * 3600 + Minutes * 60 + Seconds;
    }



    public static GameTime operator +(GameTime a, GameTime b)
    {
        return new GameTime(a.Hours + b.Hours, a.Minutes + b.Minutes, a.Seconds + b.Seconds);
    }

    public static GameTime operator -(GameTime a, GameTime b)
    {
        if (a.GetTotalSeconds() < b.GetTotalSeconds())
        {
            return new GameTime(0, 0, 0);
        }

        return new GameTime(a.Hours - b.Hours, a.Minutes - b.Minutes, a.Seconds - b.Seconds);
    }

    public static bool operator ==(GameTime a, GameTime b)
    {
        return a.GetTotalSeconds() == b.GetTotalSeconds();
    }

    public static bool operator !=(GameTime a, GameTime b)
    {
        return !(a == b);
    }

    public static bool operator <(GameTime a, GameTime b)
    {
        return a.GetTotalSeconds () < b.GetTotalSeconds();
    }

    public static bool operator >(GameTime a, GameTime b)
    {
        return a.GetTotalSeconds() > b.GetTotalSeconds();
    }

    public static GameTime operator *(GameTime a, int mult)
    {
        return new GameTime(a.Hours * mult, a.Minutes * mult, a.Seconds * mult);
    }

    public override string ToString()
    {
        return $"{Hours}h {Minutes}m {Seconds}s";
    }

    public override bool Equals(object obj)
    {
        if (obj is GameTime time)
        {
            return this == time;
        }

        return false ;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Hours, Minutes, Seconds);
    }
}