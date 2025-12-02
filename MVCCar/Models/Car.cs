namespace MVCCar.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Manufacturer { get; set; } = string.Empty;   // ⇦ OVDJE DODANO
        public string Color { get; set; } = string.Empty;
        public int ProductionYear { get; set; }
        public decimal Price { get; set; }
    }
}