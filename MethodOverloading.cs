using System;


public class Program
{
    // Method overloadign allows a class to have multiple methods with the same name but with a different signature. In C# methods can be overloaded based on the number, type(int, float etc) and kind(value, ref, out) of parameters.
    // Signature consists of name of method and the type, kind(value, ref, out) and the number of parameters.
    //Signature doesnt inclue return type and params modifier.

    public static void Main()
    {

    }

    public static void Add(int a, int b)
    {

    }
    public static void Add(float a, float b)
    {

    }
    public static void Add(int a, float b)
    {

    }
}