using Aplicacion.Repository;
using Dominio.Interfaces;
using Persistencia.Data;

namespace Aplicacion.UnitOfWork;
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly DbAppContext ? _Context;
        public UnitOfWork(DbAppContext context){
            _Context = context;
        }



        RolRepository ? _Rol;
        UsuarioRepository ? _Usuario;



        
        public IRol Roles => _Rol ??= new RolRepository(_Context!);
        public IUsuario Usuarios => _Usuario ??= new UsuarioRepository(_Context!);
/////////////////////////////////////////////////////////////////////////////////faltan configurar
    public ICategoria Categorias => throw new NotImplementedException();

    public IChef Chefs => throw new NotImplementedException();

    public IHamburguesa Hamburguesas => throw new NotImplementedException();

    public IHamburguesaIngrediente IHamburguesasIngredientes => throw new NotImplementedException();

    public IIngrediente Ingredientes => throw new NotImplementedException();

    public void Dispose(){
            _Context!.Dispose();
            GC.SuppressFinalize(this); 
        }

        public Task<int> SaveAsync(){
            return _Context!.SaveChangesAsync();
        }
    }
