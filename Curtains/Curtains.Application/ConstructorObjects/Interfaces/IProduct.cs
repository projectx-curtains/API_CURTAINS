namespace Curtains.Application.ConstructorObjects.Interfaces
{
    /// <summary>
    ///  Defines a product capable of returning information required for an order
    /// </summary>
    public interface IProduct
    {
        string ToOrderMessage();
    }
}