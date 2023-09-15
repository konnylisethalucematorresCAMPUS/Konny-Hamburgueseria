using System.ComponentModel.DataAnnotations;

namespace API.Dtos;

    public class ChefDto
    {
        [Required]
        public string ? Nombre { get; set; }
        [Required]
        public string? Especialidad { get; set; }
    }
