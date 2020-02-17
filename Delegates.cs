// Delegate is a type safe function pointer. so it holds a reference to a function
// Signature of delegate must match the signature of the function. (Type Safe) (return Type)
// Delegate is similar to class. You can create a instance of it and you must pass the function name as parameter


public delegate void HelloFunctionDelegate(string Message);
class Program
{
    public static void Main()
    {
        HelloFunctionDelegate del = new HelloFunctionDelegate(Hello);
        del("Hello From Delegate");

    }

    public static void Hello(string strMessage)
    {
        System.Console.WriteLine(strMessage);
    }


}