using System.ComponentModel.DataAnnotations;

namespace MVCCar.Models
{
    public class Car
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Color { get; set; }
        [Display(Name = "Production Year")]
        public int ProductionYear { get; set; }
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
        public string Manufacturer { get; set; }
    }
}

