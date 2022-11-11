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

        public async Task SendAsync(string subject, string body, string customerEmail)
        {
            var from = new MailAddress(_config["EmailSettings:SystemEmail"], _config["EmailSettings:SystemName"]);
            var to = new MailAddress(customerEmail);
            using var message = new MailMessage(from, to)
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