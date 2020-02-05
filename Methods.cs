class Program
{
    // Attribute
    //Access-Modifier Return-Type Method-Name()
    //{
    // Method Body
    //}

    public static void main()
    {

        // To Invoke Static method
        Program.Even();
        Even();

        // To Invoke Instance(Non Static) method
        Program p = new Program();
        p.Odd();
        Odd();
    }

    public static void Even()
    {

    }

    public void Odd()
    {

    }
}