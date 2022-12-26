namespace Curtains.Application.CurtainsService.Interfaces
{
    /// <summary>
    /// This interface describes the message sender that send message to customer.
    /// </summary>
    public interface IMessageSender
    {
        public Task SendMessageToCustomerAsync(string subject, string body, string customerData);
    }
}
