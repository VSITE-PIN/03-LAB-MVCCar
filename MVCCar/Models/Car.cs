using System.ComponentModel.DataAnnotations;

namespace MVCCar.Models
{
    public class Car
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Color { get; set; }

        [Range(1900, 2050)]
        public int ProductionYear { get; set; }

        [Range(0, 1000000)]
        public decimal Price { get; set; }

        public string Manufacturer { get; set; }
    }
}

