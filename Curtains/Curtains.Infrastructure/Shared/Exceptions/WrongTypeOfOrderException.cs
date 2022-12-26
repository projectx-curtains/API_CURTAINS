namespace Curtains.Infrastructure.Shared.Exceptions
{
    /// <summary>
    /// This class represents an exception that will throw when the wrong data type is sent to the notify service
    /// </summary>
    public class WrongTypeOfOrderException : Exception
    {
        public WrongTypeOfOrderException()
        {
        }

        public WrongTypeOfOrderException(string resourceName, Exception inner = null)
            : base("Wrong type of order: " + resourceName, inner)
        {
        }
    }
}
