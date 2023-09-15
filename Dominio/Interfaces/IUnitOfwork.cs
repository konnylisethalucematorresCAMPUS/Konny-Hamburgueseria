namespace Dominio.Interfaces;
    public interface IUnitOfWork{
        
        IUsuario Usuarios {get;}
        IRol Roles {get;}
        ICategoria  Categorias {get;}
        IChef Chefs {get;}
        IHamburguesa Hamburguesas {get;}
        IHamburguesaIngrediente IHamburguesasIngredientes {get;}
        IIngrediente Ingredientes {get;}
        Task<int> SaveAsync();
        
    }
