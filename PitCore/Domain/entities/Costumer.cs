using System.ComponentModel.DataAnnotations;

namespace PitCore.Domain.entities
{
    public class Costumer
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string Email { get; set; } = string.Empty;

        [Required]
        public int Fone { get; set; }

        public List<Vehicle> Vehicles { get; set; } = [];

    }
}
