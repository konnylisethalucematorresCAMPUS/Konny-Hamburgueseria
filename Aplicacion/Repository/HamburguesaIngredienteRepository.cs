using Dominio.Entities;
using Dominio.Interfaces;
using Persistencia.Data;

namespace Aplicacion.Repository
{
    public class HamburguesaIngredienteRepository: GenericRepository<HamburguesaIngrediente>, IHamburguesaIngrediente
    {
          private readonly DbAppContext _Context;
        public HamburguesaIngredienteRepository(DbAppContext context) : base(context)
        {
            _Context = context;
        }
    }
}


