
using System;
using System.ComponentModel.DataAnnotations;

namespace EverythingFarm_Eat.Components.Models
{
    public class ContactForm
    {
        
        public required string FirstName { get; set; }

        
        public required string LastName { get; set; }

        
        public required string Email { get; set; }

        
        public required string Phone { get; set; }

         
        public DateTime ReservationDateTime { get; set; }

        
        public string? Subject { get; set; }

        
        public required string Message { get; set; }

        
    }
}
