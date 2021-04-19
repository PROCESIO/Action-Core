using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Ringhel.Procesio.Action.Core.Models.Credentials.SMTP
{
    public interface ISmtpClient
    {
        public Task SendEmail(MailMessage mailMessage, List<FileModel> attachments);
    }
}
