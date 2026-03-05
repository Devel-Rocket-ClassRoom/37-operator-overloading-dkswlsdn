using System;

{
    Console.WriteLine("\n==========================");

    Counter c = new Counter(5);
    Console.WriteLine(-c);
    Console.WriteLine(++c);
}

{
    Console.WriteLine("\n==========================");

    Fraction a = new Fraction(1, 2);
    Fraction b = new Fraction(1, 3);

    Console.WriteLine(a + b);
    Console.WriteLine(a * b);
}

{
    Console.WriteLine("\n==========================");

    Money money1 = new Money(1000, "KRW");
    Money money2 = new Money(2000, "KRW");

    Console.WriteLine(money1 == money2);
    Console.WriteLine(money1 < money2);
}

{
    Console.WriteLine("\n==========================");

    Vector2 vector = new Vector2(1, 2);

    vector += new Vector2(3, 4);

    Console.WriteLine(vector);
}

{
    Console.WriteLine("\n==========================");

    Celsius temp = 36.5;
    double value = temp;

    Console.WriteLine(value);
}