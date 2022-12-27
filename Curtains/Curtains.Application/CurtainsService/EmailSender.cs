using System.Net;
using System.Net.Mail;
using Curtains.Application.CurtainsService.Interfaces;
using Microsoft.Extensions.Configuration;

namespace Curtains.Application.CurtainsService
{
    public class EmailSender : IMessageSender
    {
        private readonly string _systemEmail;
        private readonly string _systemName;
        private readonly IConfiguration _config;

        public EmailSender(IConfiguration config)
        {
            _config = config;
            _systemEmail = config["EmailSettings:SystemEmail"];
            _systemName = config["EmailSettings:SystemName"];
        }

        /// <summary>
        /// Sends a message to a specific email address
        /// </summary>
        /// <param name="customerEmail">The mail to which the message is sent</param>
        public async Task SendMessageToCustomerAsync(string subject, string body, string customerEmail)
        {
            var systemAddress = new MailAddress(_systemEmail, _systemName);
            var customerAddress = new MailAddress(customerEmail);
            using var message = new MailMessage(systemAddress, customerAddress)
            {
                Subject = subject,
                Body = body,
                IsBodyHtml = true
            };

            using var smtp = new SmtpClient(_config["EmailSettings:SmtpClient"], int.Parse(_config["EmailSettings:Port"]))
            {
                EnableSsl = true,
                Credentials = new NetworkCredential(_systemEmail, _config["EmailSettings:SystemPassword"])
            };

            await smtp.SendMailAsync(message);
        }
    }
}