// Interface cannot have fields
// Interface are public by default 
// Interface cannot have access modifier
// Interface cannot have method definition
// Interface can inherit from another interface.
// Classes can inherit from more than one interface, but can only inherit from a single class
// If a class inherits from a interface, it has to provide implementation for all methods
// We cannot create a instance of an interface but can point to a derived class object.


using System;

interface ICustomer
{
    void Print();
    
}

class Customer : ICustomer

{
    public void Print(){
        System.Console.WriteLine();
    }
}

public class Program
{
    public static void Main()
    {
        Customer C1 = new Customer();
        C1.Print();
    }
}
