using Microsoft.AspNetCore.Components.Forms;

namespace EverythingFarm_Eat.Components.Models
{
    public record CustomerForm
    {
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string Email { get; set; }
        public required string Phone { get; set; }
        public required string StreetAddress { get; set; }
        public string? Address2 { get; set; }
        public required string City { get; set; }
        public required string State { get; set; }
        public required string ZipCode { get; set;}
        public required string ClientEmail { get; set;}
        public required string Message { get; set;}
        public required bool Item { get; set; }
        public required decimal Price { get; set; }
        public required int Quantity { get; set; }
        public required decimal Total { get; set; }
        
    }
}
