using System;
using System.Collections.Generic;
using System.Text;

namespace Ringhel.Procesio.Action.Core.Models.Credentials.SMTP
{
    public class MailMessage
    {
        /// <summary>
        /// Sender email address.
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Sender display name
        /// </summary>
        public string From { get; set; }

        /// <summary>
        /// Body message
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// Subject message
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// To emails
        /// </summary>
        public IEnumerable<string> To { get; set; }

        /// <summary>
        /// Cc emails
        /// </summary>
        public IEnumerable<string> Cc { get; set; }

        /// <summary>
        /// Bcc emails
        /// </summary>
        public IEnumerable<string> Bcc { get; set; }

        /// <summary>
        /// Type of boyd html/text.
        /// </summary>
        public bool IsBodyHtml { get; set; }
    }
}
