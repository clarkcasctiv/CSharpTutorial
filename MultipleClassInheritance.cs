using System;

public class A {
    public virtual void Print()
    {
        System.Console.WriteLine("A");
    }
}

public class B : A{
public override void Print()
    {
        System.Console.WriteLine("B");
    }
}

public class C : A
{
    public override void Print()
    {
        System.Console.WriteLine("C");
    }
}

// Multiple class inheritance
// Ambiguity due to which class does Class D inherit from? B or C?
// public class D : B,C 
// {
// }


// Class A
//   /   \
// Class B Class C
//  \    /
// Class D

// Diamond Problem