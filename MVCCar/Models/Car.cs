namespace MVCCar.Models
{
    public class Car
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Color { get; set; }
        public int ProductionYear { get; set; }
        public decimal Price { get; set; }
        public required string Manufacturer { get; set; }
    }
}
