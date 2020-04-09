using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Filmania.WebApi.Repositories
{
    public class SendEmailNotificationRepository : ISendNotificationRepository
    {
        private async Task SendEmailAsync(string email,string body)
        {
            var client = new SmtpClient()
            {
                Host = "smtp.office365.com",
                Port = 587,
                EnableSsl = true,
                Timeout = 10000,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential("konstantinos.kritikakis@outlook.com","")
            };


            var msg = new MailMessage();
            msg.To.Add(email);
            msg.From = new MailAddress("konstantinos.kritikakis@outlook.com");
            msg.Subject = "Geia";
            msg.Body = body;

            await client.SendMailAsync(msg);
        }
        public async Task SendNotificationAsync(string email, string body)
        {
            await SendEmailAsync(email, body);
        }
    }
}
