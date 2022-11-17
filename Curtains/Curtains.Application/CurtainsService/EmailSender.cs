using System.Net;
using System.Net.Mail;
using Curtains.Application.Interfaces;
using Microsoft.Extensions.Configuration;

namespace Curtains.Application.CurtainsService
{
    public class EmailSender : IMessageSender
    {
        private readonly IConfiguration _config;
        public EmailSender(IConfiguration config)
        {
            _config = config;
        }

        /// <summary>
        /// Sends a message to a specific address to an email address
        /// </summary>
        /// <param name="customerEmail">The mail to which the message is sent</param>
        public async Task SendAsync(string subject, string body, string customerEmail)
        {
            var systemAddress = new MailAddress(_config["EmailSettings:SystemEmail"], _config["EmailSettings:SystemName"]);
            var customerAddress = new MailAddress(customerEmail);
            using var message = new MailMessage(systemAddress, customerAddress)
            {
                Subject = subject,
                Body = body,
                IsBodyHtml = true
            };

            using var smtp = new SmtpClient(_config["EmailSettings:SmtpClient"], 587)
            {
                EnableSsl = true,
                Credentials = new NetworkCredential(_config["EmailSettings:SystemEmail"], _config["EmailSettings:SystemPassword"])
            };

            await smtp.SendMailAsync(message);
        }
    }
}