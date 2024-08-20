using System;
using System.Collections.Generic;

namespace Ringhel.Procesio.Action.Core.Models.Credentials.SMTP
{
    public class BasicErrorEmailInformation
    {
        public int Id { get; set; }
        public string AttachmentName { get; set; }
        public string Subject { get; set; }
        public string To { get; set; }
        public string Sender { get; set; }
        public string ErrorReason { get; set; }
        public DateTime SendDate { get; set; }
    }
}
