using System;
using System.Runtime.Serialization;

namespace csharptutorial
{
    public class CustomException
    {
        public static void Main()
        {
            try
            {
                throw new UserAlreadyLoggedInException("User is already logged in");

            }
            catch (UserAlreadyLoggedInException ex)
            {

                System.Console.WriteLine(ex.Message);
            }


        }
    }

    [Serializable]
    public class UserAlreadyLoggedInException : Exception
    {
        public UserAlreadyLoggedInException() : base()
        {

        }
        public UserAlreadyLoggedInException(string message) : base(message)
        {

        }
        public UserAlreadyLoggedInException(string message, Exception innerException) : base(message, innerException)
        {

        }

        public UserAlreadyLoggedInException(SerializationInfo info, StreamingContext context) : base(info, context)
        {

        }
    }

}