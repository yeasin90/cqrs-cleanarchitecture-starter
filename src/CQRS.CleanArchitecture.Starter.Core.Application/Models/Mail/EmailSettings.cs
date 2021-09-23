namespace CQRS.CleanArchitecture.Starter.Core.Application.Models.Mail
{
    // Note: this class is NOT placed under CQRS.CleanArchitecture.Starter.Core.Domain project
    // It's because, this is not a domain class
    // This is just a configuration class used by Email service
    public class EmailSettings
    {
        public string ApiKey { get; set; }
        public string FromAddress { get; set; }
        public string FromName { get; set; }
    }
}
