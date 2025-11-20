using System.ComponentModel.DataAnnotations.Schema;

namespace MVCCar.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public int ProductionYear { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal Price { get; set; }
        public string Manufacturer { get; set; }
    }
}
