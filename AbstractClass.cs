// abstract keyword is used to create abstract class
// abstract class contains only the method definition
// abstract class can only be used as an base class
// abstract class cannot be sealed
// abstract class may contain abstract members but not mandatory
// a non abstract class derived from abstract class must provide implementation for all inherited members
//or declare itself abstract

using System;

public abstract class Customer
{
    public abstract void Print();
    
}

public class Program : Customer
{
    public override void Print()
    {
System.Console.WriteLine("Print");
    }

    public static void Main()
    {

    }
}