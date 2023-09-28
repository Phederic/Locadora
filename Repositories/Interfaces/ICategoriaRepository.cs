using Locadora.Models;

namespace Locadora.Repositories.Interfaces
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> Todos { get; }
        Categoria Get(int id);
    }
}
