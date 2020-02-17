public class BaseClass
{
    public virtual void Print()
    {
        System.Console.WriteLine("Base Class");
    }

    
}

// Method Overriding
public class DerivedClass: BaseClass
{
    // A base class reference pointing to a child class object will invoke the overridden method in the child class
    public override void Print()
    {
        System.Console.WriteLine("Derived Class");
    }


}

// Method Hiding
public class DerivedClass1 : BaseClass
{
    // A base class reference pointing to a child class object will invoke the hidden method in the base class
    public new void Print()
    {
        System.Console.WriteLine("Derived Class");
    }


}

public class Program
{
    public static void Main()
    {
        BaseClass B = new DerivedClass();
        B.Print();
    }
}