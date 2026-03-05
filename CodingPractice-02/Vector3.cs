using System;
using System.Collections.Generic;
using System.Text;

public struct Vector3
{
    public float X;
    public float Y;
    public float Z;


    public Vector3(float x, float y, float z)
    {
        X = x;
        Y = y;
        Z = z;
    }


    public static Vector3 operator +(Vector3 v1, Vector3 v2)
    {
        return new Vector3(v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z);
    }

    public static Vector3 operator -(Vector3 v1, Vector3 v2)
    {
        return new Vector3(v1.X - v2.X, v1.Y - v2.Y, v1.Z - v2.Z);
    }

    public static Vector3 operator *(Vector3 v1, int mult)
    {
        return new Vector3(v1.X * mult, v1.Y * mult, v1.Z * mult);
    }

    public static Vector3 operator *(int mult, Vector3 v1)
    {
        return new Vector3(v1.X * mult, v1.Y * mult, v1.Z * mult);
    }

    public static Vector3 operator -(Vector3 vector)
    {
        return new Vector3(-vector.X, -vector.Y, -vector.Z);
    }

    public static bool operator ==(Vector3 v1, Vector3 v2)
    {
        return v1.X == v2.X && v1.Y == v2.Y && v1.Z == v2.Z;
    }

    public static bool operator !=(Vector3 v1, Vector3 v2)
    {
        return !(v1 == v2);
    }

    public override bool Equals(object obj)
    {
        if (obj is Vector3 other)
        {
            return this == other;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(X, Y, Z);
    }


    public override string ToString()
    {
        return $"({X}, {Y}, {Z})";
    }
}