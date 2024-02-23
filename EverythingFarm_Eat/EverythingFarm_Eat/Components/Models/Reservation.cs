using Microsoft.AspNetCore.Components.Routing;

namespace EverythingFarm_Eat.Components.Models
{
    public record Reservation
    {
        private DateTime? ReserveTime { get; set; }
        private DateOnly ReserveDate { get; set; }
        private string? ReserveTable { get; set; }
        public required string Location { get; set; }
        private bool TakeOut { get; set; }
    }
}
