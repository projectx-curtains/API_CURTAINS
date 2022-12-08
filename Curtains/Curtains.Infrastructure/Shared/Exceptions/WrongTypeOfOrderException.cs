namespace Curtains.Infrastructure.Shared.Exceptions
{
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
