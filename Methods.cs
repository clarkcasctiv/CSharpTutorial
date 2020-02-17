class Program
{
    // Attribute
    //Access-Modifier Return-Type Method-Name()
    //{
    // Method Body
    //}

    public static void Main()
    {

        // To Invoke Static method
        Program10.Even();
        Even();

        // To Invoke Instance(Non Static) method
        Program10 p = new Program10();
        p.Odd();
    }

    public static void Even()
    {

    }

    public void Odd()
    {

    }
}