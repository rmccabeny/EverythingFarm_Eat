namespace EverythingFarm_Eat.Components.Models
{
    public record Customer
    {
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string Email { get; set; }
        public required string PhoneNum { get; set; }
        public required string StreetAddress { get; set; }
        public string? Address2 { get; set; }
        public required string City { get; set; }
        public required string State { get; set; }
        public required string ZipCode { get; set;}
        public required string ClientEmail { get; set;}

       
    }
}
