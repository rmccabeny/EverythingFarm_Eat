namespace EverythingFarm_Eat.Components.Models
{
    public record Menu
    {
        public string? BreakfastChoice { get; set; }
        public string? Appetizer { get; set; }
        public string? SoupSalad { get; set; }
        public string? BurgersDogs { get; set; }
        public string? Subs { get; set; }
        public string? EntreeChoice { get; set; }
        public string? SideChoice { get; set; }
        public string? AddOns { get; set; }
        public string? KidsMenu { get; set; }
        public string? FamStylOpt { get; set; }
        public string? Drinks { get; set; }
        public required decimal MenuPrice { get; set; }


    }
}
