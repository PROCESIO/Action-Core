using System.Net.Mail;

namespace Ringhel.Procesio.Action.Core.Models.Credentials.SMTP
{
    public class SMTPCredentialsManager
    {
        public SMTPCredentialsConfiguration CredentialsConfiguration { get; set; }

        public ISmtpClient Client { get; set; }
    }
}
