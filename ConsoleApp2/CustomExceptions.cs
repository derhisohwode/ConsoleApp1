using System;
using System.IO;
using System.Runtime.Serialization;

public class CustomExceptions
{
    public static void Main22()
    {
        try
        {
			throw new UserAlreadyLoggedInException("User Already Logged In");
		}
        catch (UserAlreadyLoggedInException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

public class UserAlreadyLoggedInException : Exception
{
    public UserAlreadyLoggedInException() : base()
    {

    }

    public UserAlreadyLoggedInException(string message) : base(message)
    {

    }

    public UserAlreadyLoggedInException(string message, Exception innerException) : base(message,innerException)
    {

    }

    public UserAlreadyLoggedInException(SerializationInfo info, StreamingContext context) : base(info, context)
    {

    }
}