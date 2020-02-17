using System;

public class Employee
{
    public string FirstName;
    public string LastName;
    public string Email;

    public void PrintName()
    {
        System.Console.WriteLine(FirstName + "" + LastName);

    }
}

public class FullTimeEmployee : Employee
{
    public float YearlySalary;
}


public class PartTimeEmployee : Employee
{
    public float HourlySalary;
}

public class Program
{
    public static void Main()
    {
        FullTimeEmployee a = new FullTimeEmployee();
        a.FirstName = "";
        a.Email = "";
        a.PrintName();
    }
}


// Pillars of Object Oriented Programming
// Inheritance
// Polymorphism
// Encapsulation
// Abstraction


// Mulitple class inheritance is not possible whereas Multi Level class inheritance is possible
// Base classes are instantiated before derived classes.
// base keyword can be used to control which constructor gets called from base constructor
// public class b: base("")