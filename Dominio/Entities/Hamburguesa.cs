namespace Dominio.Entities;

    public class Hamburguesa : BaseEntity
    {
    public string ? Nombre { get; set; }

        public int  IdCategoria { get; set; }
        public Categoria ? Categorias { get; set;}

        public int ? Precio { get; set; }

        public int IdChef { get; set; }
        public Chef ? Chefs { get; set; }

        public ICollection<HamburguesaIngrediente> ? HamburguesasIngredientes { get; set; } = new HashSet<HamburguesaIngrediente>();
    public object RefreshTokens { get; set; }
}
