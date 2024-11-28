namespace MVCCar.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Color { get; set; } = string.Empty;
        public int ProductionYear { get; set; } = 0;
        public decimal Price { get; set; }

        public string Manufacturer { get; set; }
    }
}



