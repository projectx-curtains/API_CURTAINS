namespace Curtains.Infrastructure.Shared.Exceptions
{
    public class ResourceNotFoundException : Exception
    {
        public ResourceNotFoundException()
        {
        }

        public ResourceNotFoundException(string resourceName, Exception inner = null)
            : base("Resource(s) not found: " + resourceName, inner)
        {
        }
    }    
}
