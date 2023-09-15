using Dominio.Entities;
namespace Dominio.Interfaces;

    public interface IHamburguesa : IGenericRepository<Hamburguesa>{
        Task<Hamburguesa> GetByNombreAsync(string nombre);
        Task<Hamburguesa> GetByCategoriaAsync(string categoria);

    }
