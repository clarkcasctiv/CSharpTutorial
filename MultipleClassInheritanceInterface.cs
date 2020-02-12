using System;

interface I
{
    void Method1();
}
class A : I
{
    public void Method1(){
        System.Console.WriteLine("A");
    }
}

interface J
{
    void Method2();
}
class B : J
{
    public void Method2()
    {
        System.Console.WriteLine("B");
    }
}

class AB : I, J
{
    

    A a = new A();
    B b = new B();

    public void Method1()
    {
        a.Method1();
    }
    public void Method2()
    {
        b.Method2();

    }
}

class Program
{
    public static void Main()
    {
        AB ab = new AB();
        ab.Method1();
        ab.Method2();
    }
}