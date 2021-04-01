namespace Ringhel.Procesio.Action.Core.Models.Credentials.SMTP
{
    public class SMTPCredentialsConfiguration
    {
        public string Host { get; set; }

        public int Port { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public EncryptionTypes EncryptionType { get; set; }

        public MailDirectionTypes MailDirection { get; set; }

        public MailClientTypes Protocol { get; set; }
    }
}
