using PitCore.Domain.enums;
using System.ComponentModel.DataAnnotations;

namespace PitCore.Domain.entities
{
    public class Vehicle
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Brand { get; set; } = string.Empty;

        [Required]
        public string Model { get; set; } = string.Empty;

        [Required]
        public string Color { get; set; } = string.Empty;

        [Required]
        public string Plate { get; set; } = string.Empty;

        [Required]  
        public int Year { get; set; }

        [Required]
        public int Engine { get; set; }

        public Guid CostumerId { get; set; }
        public Costumer Costumer { get; set; } = null!;
        public VehicleConfigurationType ConfigurationType { get; set; }
    }
}
