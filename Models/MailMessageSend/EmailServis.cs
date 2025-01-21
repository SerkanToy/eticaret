using Microsoft.Extensions.Options;
using System.Net.Mail;
using System.Net;

namespace eticaret.Models.MailMessageSend
{
    public class EmailServis: IEmailServis
    {
        private readonly EmailConfiguration emailConfiguration;
        public EmailServis(IOptions<EmailConfiguration> options)
        {
            emailConfiguration = options.Value;
        }
        public void SendEmail(string emailLink, string ToEmail, string subject, string body)
        {
            var smtpClient = new SmtpClient();
            smtpClient.Host = "smtp.gmail.com";
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            //smtpClient.UseDefaultCredentials = true;
            smtpClient.Port = emailConfiguration.Port;
            smtpClient.Credentials = new NetworkCredential(emailConfiguration.UserName, emailConfiguration.Password);
            smtpClient.EnableSsl = true;
            var mailMessage = new MailMessage();
            mailMessage.From = new MailAddress(emailConfiguration.UserName);
            mailMessage.Subject = subject;
            mailMessage.Body = $"{body}";
            mailMessage.IsBodyHtml = true;
            mailMessage.To.Add(ToEmail);
            smtpClient.Send(mailMessage);
        }

    }
}
