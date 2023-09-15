
namespace Dominio.Entities;

    public class HamburguesaIngrediente : BaseEntity 
    {
        public int IdHamburguesa { get; set; }
        public Hamburguesa ? Hamburguesas { get; set; }

        public int IdIngrediente { get; set; }
        public Ingrediente ? Ingredientes { get; set;}

}
