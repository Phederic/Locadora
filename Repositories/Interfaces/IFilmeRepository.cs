using Locadora.Models;
using System.Linq;

namespace Locadora.Repositories.Interfaces
{
    public interface IFilmeRepository
    {
        IEnumerable<Filme> Todos { get; }
        Filme Get(int id);
    }
}
