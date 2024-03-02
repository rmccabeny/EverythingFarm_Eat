using Org.BouncyCastle.Crmf;
using System.ComponentModel.DataAnnotations;
using System.Net.Sockets;

namespace EverythingFarm_Eat.Components.Models
{
    public record ContactForm
    {
        
        public required string ContactFirstName { get; set; }
        
        public required string ContactLastName { get; set;}
        
        public required string ContactEmail { get; set; }
        public required string ContactPhone { get; set;}
        public required string ContactStreetAddr { get; set; }
        public string? ContactAddr2 { get; set; }
        public required string ContactCity { get; set;}
        public required string ContactState { get; set;}
        public required string ContactZipCode { get; set;}
        public required DateTime ReservationDate { get; set;}
        public required TimeOnly ReservationTime { get; set;}
        public required string  Message { get; set;}
    }
}
