using System.ComponentModel.DataAnnotations;

namespace API.Dtos;
    public class Hamburguesa
    {
            [Required]
            public string ? Nombre { get; set; }
            [Required]
            public int ? Precio { get; set; }

    }
