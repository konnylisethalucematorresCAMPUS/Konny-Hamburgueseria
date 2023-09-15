using System.ComponentModel.DataAnnotations;

namespace API.Dtos;

    public class RegistrarIngredienteDto
    {
        [Required]
        public string ? Nombre { get; set; }
        [Required]
        public string ? Descripcion { get; set; }
        [Required]
        public int  Precio { get; set; }
        [Required]
        public int Stock { get; set; }
    }
