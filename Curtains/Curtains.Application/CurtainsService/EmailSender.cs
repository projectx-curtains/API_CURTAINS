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

        public async Task SendAsync(string subject, string body)
        {
            MailAddress from = new MailAddress("etolokonnikov0601@gmail.com", "Egor");
            MailAddress to = new MailAddress("otsengeme@gmail.com");
            MailMessage m = new MailMessage(from, to);
            m.Subject = subject;
            m.Body = body;
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.EnableSsl = true;
            smtp.Credentials = new NetworkCredential("etolokonnikov0601@gmail.com", "xwpipvzcsfxppafv");
            await smtp.SendMailAsync(m);
            Console.WriteLine("Письмо отправлено");
        }
    }
}