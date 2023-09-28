using Locadora.Models;
using Locadora.Models.Context;
using Locadora.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace Locadora.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _dbContext;

        public CategoriaRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IEnumerable<Categoria> Todos => _dbContext.Categorias;

        public Categoria Get(int id)
        {
            var categoria = _dbContext.Categorias.FirstOrDefault(c => c.Id == id);
            return categoria;
        }
    }
}
