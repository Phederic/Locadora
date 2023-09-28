using Locadora.Models;
using Locadora.Models.Context;
using Locadora.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Locadora.Repositories
{
    public class FilmeRepository : IFilmeRepository
    {
        private readonly AppDbContext _context;
        public FilmeRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Filme> Todos =>  _context.Filme.Include(x => x.Categoria);

        public Filme Get(int id)
        {
            var filme = _context.Filme.FirstOrDefault(c => c.Id == id);
            return filme;
        }
    }
}
