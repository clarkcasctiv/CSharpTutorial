using System;
using System.IO;

namespace csharptutorial
{
    class ExceptionHandling
    {
        public static void Main()
        {
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(@"C:\Data.txt");
                // StreamReader sr = new StreamReader("C:\\Data.txt");
                System.Console.WriteLine(sr.ReadToEnd());
            }
            catch(FileNotFoundException ex)
            {
                System.Console.WriteLine(ex.Message);

            }
            catch (System.Exception ex)
            {
                System.Console.WriteLine(ex.StackTrace);
            }
            finally {
                if(sr != null)
                {
                    sr.Close();

                }
            }
           
        }
    }
}
