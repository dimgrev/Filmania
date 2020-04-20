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
        private async Task SendEmailAsync(List<string> emailList,string body)
        {
            //Filter Sending Emails only to outlook reciepients
            var emailListOnlyOutlook = emailList.Where(e => e.Contains("@outlook.com")).ToList();
            var emailListAsString = String.Join(',', emailListOnlyOutlook);

            var client = new SmtpClient()
            {
                Host = "smtp.office365.com",
                Port = 587,
                EnableSsl = true,
                Timeout = 10000,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential("konstantinos.kritikakis@outlook.com","77java&&")
            };


            var msg = new MailMessage();
            msg.To.Add(emailListAsString);
            msg.From = new MailAddress("konstantinos.kritikakis@outlook.com");
            msg.Subject = "Geia";
            msg.Body = body;

            await client.SendMailAsync(msg);
        }
        public async Task SendNotificationAsync(List<string> emailList, string body)
        {
            await SendEmailAsync(emailList, body);
        }
    }
}
