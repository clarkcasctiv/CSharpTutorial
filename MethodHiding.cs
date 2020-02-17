
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

// Use new keyword to use the method in derived class instead of base class
    public new void PrintName()
    {
        System.Console.WriteLine(FirstName + "-" + LastName);
    }
}


public class PartTimeEmployee : Employee
{
    public float HourlySalary;

    public new void PrintName()
    {
        // use the base keyword to use the method in base class instead of derived class
        base.PrintName();
    }
}

public class Program
{
    public static void Main()
    {
        FullTimeEmployee a = new FullTimeEmployee();
        a.FirstName = "";
        a.Email = "";
        a.PrintName();

        // PartTimeEmployee b = new PartTimeEmployee();
        // Can also use the base class in left of the instance creation of the derived class.
      
        Employee b = new PartTimeEmployee();
        // Parent class can point to child class but reverse is not possible

        //PartTimeEmployee b = new Employee() => Gives Error
        b.FirstName = "";
        b.Email = "";
        // b.PrintName();
        // Can also use the cast operator to convert the derived class to base class
        ((Employee)b).PrintName();
    }



}