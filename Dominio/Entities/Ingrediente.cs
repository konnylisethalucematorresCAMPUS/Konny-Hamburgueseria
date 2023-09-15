using System.Numerics;

namespace Dominio.Entities;

    public class Ingrediente: BaseEntity
    {
        public string ? Nombre { get; set; }
        public string ? Descripcion { get; set; }
        public int  Precio { get; set; }
        public int Stock { get; set; }
        public ICollection<HamburguesaIngrediente> ? HamburguesasIngredientes { get; set; }= new HashSet<HamburguesaIngrediente>();
    }
