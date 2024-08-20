namespace Ringhel.Procesio.Action.Core.Models.Credentials.SMTP;

public class EmailsInformation
{
    public List<BasicEmailInformation> BasicInformation { get; set; } = new List<BasicEmailInformation>();
    public List<BasicErrorEmailInformation> BasicErrorInformation { get; set; } = new List<BasicErrorEmailInformation>();
    public List<FileModel> Attachments { get; set; } = new List<FileModel>();
}
