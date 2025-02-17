﻿namespace Ringhel.Procesio.Action.Core.Models.Credentials.SMTP;

public interface ISmtpClient
{
    public Task SendEmail(MailMessage mailMessage, List<FileModel> attachments);
    public Task<EmailsInformation> ReadEmails(bool unread, bool hasAttachments, List<string> inputFilters);
}
