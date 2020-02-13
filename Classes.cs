using System;

public class Customer
{
    private string _firstName;
    private string _lastName;

    // Constructor
    public Customer(string firstName, string lastName)
    {
        this._firstName = firstName;
        this._lastName = lastName;
        
    }

    public Customer (): this ("Empty FirstName","Empty LastName")
    {

    }

    public void PrintName()
    {
        System.Console.WriteLine("Full Name = {0}",this._firstName + " " + this._lastName);
    }

    // Destructor
    ~Customer()
    {

    }
}

public class Program
{
    public static void Main()
    {
        Customer c1 = new Customer("Pujan","Bajra");
        Customer c2 = new Customer();
        c1.PrintName();

    }
}