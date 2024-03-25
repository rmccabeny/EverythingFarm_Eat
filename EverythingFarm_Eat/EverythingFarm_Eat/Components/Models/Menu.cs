namespace EverythingFarm_Eat.Components.Models
{
    public record Menu
    {
        public required string MealType { get; set; }
        public required string ItemCategory { get; set; }
        public required string ItemChoice { get; set; }
        public string? Appetizer { get; set; }
        public string? SoupSalad { get; set; }
        public string? EntreeChoice { get; set; }
        public string? SideChoice { get; set; }
        public string? AddToppings { get; set; }
        public string? KidsMenu { get; set; }
        public string? FamStylOpt { get; set; }
        public string? Dessert {  get; set; }
        public string? Drinks { get; set; }
        public required decimal MenuPrice { get; set; }
        public required int Quantity { get; set; }


    }
}
