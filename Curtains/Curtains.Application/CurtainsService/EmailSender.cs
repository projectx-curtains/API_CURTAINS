using System.Net;
using System.Net.Mail;
using Curtains.Application.CurtainsServices.Interfaces;
using Microsoft.Extensions.Configuration;

namespace Curtains.Application.CurtainsService
{
    public class EmailSender : IMessageSender
    {
        private const string _systemEmail = "zashtorim.noreply@gmail.com";
        private const string _systemName = "Zashtorim";
        private const string _smtpClient = "smtp.gmail.com";
        private const int _port = 587;
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
            var systemAddress = new MailAddress(_systemEmail, _systemName);
            var customerAddress = new MailAddress(customerEmail);
            using var message = new MailMessage(systemAddress, customerAddress)
            {
                Subject = subject,
                Body = body,
                IsBodyHtml = true
            };

            using var smtp = new SmtpClient(_smtpClient, _port)
            {
                EnableSsl = true,
                Credentials = new NetworkCredential(_systemEmail, _config["EmailSettings:SystemPassword"])
            };

            await smtp.SendMailAsync(message);
        }
    }
}