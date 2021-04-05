using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ringhel.Procesio.Action.Core.Models.Credentials.SMTP
{
    public interface ISmtpClient
    {
        public Task SendEmail(
            string userName,
            string from,
            string body, 
            string subject, 
            IEnumerable<string> To, 
            IEnumerable<string> Cc = null, 
            IEnumerable<string> Bcc = null, 
            bool IsHtml = false);
    }
}
