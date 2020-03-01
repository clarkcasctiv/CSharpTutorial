

// Difference Between Convert.ToString() and ToString()
// Convert.ToString() handles null whereas ToString() doesn't and throws a null exception
namespace OverrideToString
{
    public class Program
    {
        public static void Main()
        {
            int Number = 10;
            System.Console.WriteLine(Number.ToString());

            Customer C1 = new Customer();
            C1.FirstName = "Simon";
            C1.LastName = "Tan";

            System.Console.WriteLine(C1.ToString());


        }
    }


    public class Customer

    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            return this.FirstName + " " + this.LastName;
        }
    }
}