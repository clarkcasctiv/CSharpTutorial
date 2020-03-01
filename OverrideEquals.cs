
namespace OverrideEquals
{
    public class Program
    {
        public static void Main()
        {
            int i = 10;
            int j = 10;

            System.Console.WriteLine(i == j); // true
            System.Console.WriteLine(i.Equals(j)); // true


            Customer C1 = new Customer();
            C1.FirstName = "Simon";
            C1.LastName = "Tan";

            Customer C2 = C1;

            System.Console.WriteLine(C1 == C2); // true
            System.Console.WriteLine(C1.Equals(C2)); // true


            Customer C3 = new Customer();
            C3.FirstName = "Simon";
            C3.LastName = "Tan";


            System.Console.WriteLine(C1 == C3); // false
            System.Console.WriteLine(C1.Equals(C3)); // true (after overriding ) (false before)

            // Reference Equality doesnt equal Value Equality

        }
    }

    public enum Direction
    {
        East = 1,
        West = 2,
        North = 3,
        South = 4
    }

    public class Customer

    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }


            if (!(obj is Customer))
            {
                return false;
            }

            return this.FirstName == ((Customer)obj).FirstName && this.LastName == ((Customer)obj).LastName;
        }

        public override int GetHashCode()
        {
            return this.FirstName.GetHashCode() ^ this.LastName.GetHashCode();
        }


    }



}