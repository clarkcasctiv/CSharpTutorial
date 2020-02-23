
// Attributes allow you to add declarative information to your programs. This information can then be queried at runtime using reflection.
// Obsolete => Marks types and type members outdated
// WebMethod => To expose a method as an XML Web service method
// Serializable => Indicates that a class can be serialized
using System;
using System.Collections.Generic;

public class MainClass
{
    private static void Main()
    {
        // List<int> listInt = new List<int>();
        // listInt.Add(10);
        // listInt.Add(20);
        // listInt.Add(30); 
        Calculator.Add(10, 20);
        Calculator.Add(new List<int>(){10,20,30});


    }
}

public class Calculator
{
    [Obsolete("This method is obsolete",false)]
    public static int Add(int first, int second)
    {
        return first + second;
    }

    public static int Add(List<int> numbers)
    // public static int Add(params int[] numbers)
    {
        int sum = 0;

        foreach (int number in numbers)
        {
            sum = sum + number;
        }

        return sum;
    }
}