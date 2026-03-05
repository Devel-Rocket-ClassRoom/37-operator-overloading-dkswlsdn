using System;


{
    Console.WriteLine("\n==========================");

    Celsius celsius = new Celsius(100);

    Console.WriteLine(celsius);
    Console.WriteLine((Fahrenheit)celsius);
}

{
    Console.WriteLine("\n==========================");

    Vector3 v1 = new Vector3(1, 2, 3);
    Vector3 v2 = new Vector3(4, 5, 6);

    Console.WriteLine(v1 + v2);
    Console.WriteLine(v1 - v2);
    Console.WriteLine(v1 * 2);
    Console.WriteLine(3 * v2);
    Console.WriteLine(-v1);
    Console.WriteLine(v1 == v2);
}