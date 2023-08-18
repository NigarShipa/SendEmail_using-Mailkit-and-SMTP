using SendEmail_using_Mailkit___SMTP.Models;

namespace SendEmail_using_Mailkit___SMTP.Services.EmailService
{
    public interface IEmailService
    {
        void SendEmail(EmailDto request);
    }
}
