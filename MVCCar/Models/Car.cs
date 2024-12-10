using System.ComponentModel;

namespace MVCCar.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string? Manufacturer { get; set; }
        public string? Name { get; set; }
        public string? Color { get; set; }

        [DisplayName("Production Year")]
        public int ProductionYear { get; set; }
        public decimal Price { get; set; }
    }
}
