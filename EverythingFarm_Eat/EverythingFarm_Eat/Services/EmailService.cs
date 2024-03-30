using Azure.Communication.Email;
using System.Linq.Expressions;

namespace EverythingFarm_Eat.Services
{
    // create the interface to use in the email service
    public interface IEmailService 
    {
        Task SendEmailAsync(string from, string to, string subject, string message);
    }

    // create the email service utilizing the interface to create the email client
    public class EmailService(EmailClient emailClient) : IEmailService
    {
        private readonly EmailClient emailClient = emailClient;

        // send the email through the service 
        public async Task SendEmailAsync(string from, string to, string subject, string message) 
        {
            var fromEmailAddress = new EmailAddress(from);
            var toEmailAddress = new EmailAddress(to);

            await emailClient.SendAsync(Azure.WaitUntil.Started, fromEmailAddress.Address, toEmailAddress.Address, subject, message);
        }
    }
}
