
// Aliases
using ateam = ProjectA.TeamA;
using bteam = ProjectA.TeamB;

class Program
{
    public static void Main()
    {
        //ProjectA.TeamA.Class1.Print();
        //ProjectB.TeamB.Class1.Print();

        ateam.Class1.Print();
        bteam.Class1.Print();
    }
}
// Namespaces can be nested in two ways

namespace ProjectA
{
    namespace TeamA
    {
        public class Class1
        {
            public static void Print()
            {
                System.Console.WriteLine("Hello!");
            }
        }
    }
}


namespace ProjectA.TeamB
{
    public class Class1
    {
        public static void Print()
        {
            System.Console.WriteLine("Hello!");
        }
    }
}
// Namespaces dont correspond to file, directory or assembly name. They could be writtern in separate files and/or separate assemblies and still belong to same namespace

// Namespaces can contain namespaces, class, interface, struct, enum, delegate