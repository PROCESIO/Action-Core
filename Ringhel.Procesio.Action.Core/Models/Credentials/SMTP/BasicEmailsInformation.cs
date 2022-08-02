using System;
using System.Collections.Generic;

namespace Ringhel.Procesio.Action.Core.Models.Credentials.SMTP
{
    public class BasicEmailInformation
    {
        public int Id { get; set; }
        public List<Guid?> FileIds { get; set; } = new List<Guid?>();
        public string Subject { get; set; }
        public string To { get; set; }
        public string Cc { get; set; }
        public string Bcc { get; set; }
        public string Sender { get; set; }
        public string Body { get; set; }
        public string Status { get; set; }
        public int Size { get; set; }
        public DateTime SendDate { get; set; }
        public string ImportanceLevel { get; set; }
    }
}
