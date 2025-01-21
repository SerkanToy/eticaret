namespace eticaret.Models.MailMessageSend
{
    public interface IEmailServis
    {
        void SendEmail(string emailLink, string ToEmail, string subject, string body);
    }

}
