namespace EverythingFarm_Eat.Components.Models
{
    public record Delivery
    {
        private DateOnly DeliverDate { get; set; }
        private DateTime? DeliverTime { get; set; }
    }
}
