using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

public struct GameCurrency
{
    public int Gold;
    public int Silver;


    public GameCurrency(int gold, int silver)
    {
        if (silver >= 100)
        {
            gold += silver / 100;
            silver %= 100;
        }

        Gold = gold;
        Silver = silver;
    }


    public int GetTotalSilver()
    {
        return Gold * 100 + Silver; 
    }



    public static GameCurrency operator +(GameCurrency c1, GameCurrency c2)
    {
        return new GameCurrency(c1.Gold + c2.Gold, c1.Silver + c2.Silver);
    }

    public static GameCurrency operator -(GameCurrency c1, GameCurrency c2)
    {
        int gold = c1.Gold - c2.Gold;
        int silver = c1.Silver - c2.Silver;

        if (gold < 0)
        {
            return new GameCurrency(0, 0);
        }

        if (silver < 0)
        {
            gold -= -silver / 100;
            silver += (-silver / 100) * 100;
        }

        return new GameCurrency(gold, silver);
    }

    public static bool operator ==(GameCurrency c1, GameCurrency c2)
    {
        return c1.GetTotalSilver() == c2.GetTotalSilver();
    }


    public static bool operator !=(GameCurrency c1, GameCurrency c2)
    {
        return !(c1 == c2);
    }

    public static bool operator <(GameCurrency c1, GameCurrency c2)
    {
        return c1.GetTotalSilver() < c2.GetTotalSilver();
    }

    public static bool operator >(GameCurrency c1, GameCurrency c2)
    {
        return !(c1 < c2) && c1 != c2;
    }

    public override string ToString()
    {
        return $"{Gold}G {Silver}S";
    }

    public override bool Equals(object obj)
    {
        if (obj is GameCurrency currentcy)
        {
            return this == currentcy;
        }

        return false;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Gold, Silver);
    }
}