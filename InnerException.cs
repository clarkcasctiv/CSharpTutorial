using System;
using System.IO;

namespace csharptutorial
{
    class InnerException
    {
        // Original Exception can be received with inner exception in the outer try catch block
        public static void Main()
        {
            try
            {
                try
                {
                    System.Console.WriteLine("Enter First Number:");
                    int i = 10;
                    // int i = Convert.ToInt32(Console.ReadLine());

                    System.Console.WriteLine("Enter Second Number:");
                    int j = 0;
                    // int j = Convert.ToInt32(Console.ReadLine());

                    int result = i / j;

                    System.Console.WriteLine("Result = {0}", result);
                }
                catch (System.Exception ex)
                {
                    string filepath = @"C:\Log.txt";

                    if (File.Exists(filepath))
                    {
                        StreamWriter sw = new StreamWriter(filepath);
                        sw.Write(ex.GetType().Name);
                        sw.Close();
                        System.Console.WriteLine("Error Occured!");
                    }
                    else
                    {
                        throw new FileNotFoundException(filepath + "is not present!", ex);

                    }

                }
            }
            catch (System.Exception ex)
            {

                System.Console.WriteLine("Current Exception = {0}", ex.GetType().Name);

                // if ex is absent in throw new exception

                if (ex.InnerException != null)
                {
                    System.Console.WriteLine("Original Exception = {0}", ex.InnerException.GetType().Name);
                }

            }


        }

    }
}