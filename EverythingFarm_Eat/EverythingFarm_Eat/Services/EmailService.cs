using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace EverythingFarm_Eat.Services
{
    public record EmailService
    {
        private readonly string smtpServer;
        private readonly int smtpPort;
        private readonly string smtpUsername;
        private readonly string smtpPassword;

        public EmailService(string smtpServer, int smtpPort, string smtpUsername, string smtpPassword) 
        {
            this.smtpServer = smtpServer;
            this.smtpPort = smtpPort;
            this.smtpUsername = smtpUsername;
            this.smtpPassword = smtpPassword;
        }

        public async Task SendNotificationToClient(string clientEmail, string subject, string body) 
        {
            using (var client = new SmtpClient(smtpServer, smtpPort)) 
            {
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential(smtpUsername, smtpPassword);
                client.EnableSsl = true;

                var message = new MailMessage(smtpUsername, clientEmail, subject, body);
                await client.SendMailAsync(message);
                
            }
        }
    }
}
