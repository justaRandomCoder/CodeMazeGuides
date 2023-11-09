﻿namespace UsingStaticAnonymousFunctionsInCSharp.Demo;

// static anonymous function with const variable
public class DemoStaticWithConstVariable
{
    private const double numberInEnclosingScope = 4;

    void Calculate(Func<double, double> func)
    {
        Console.WriteLine(func(6));
    }

    public void Display()
    {
        Calculate(static num => Math.Pow(numberInEnclosingScope, num));
    }
}
