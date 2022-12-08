namespace Curtains.Application.CurtainsServices.Interfaces
{
    public interface IMessageSender
    {
        public Task SendAsync(string subject, string body, string customerData);
    }
}
