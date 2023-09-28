using Locadora.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Locadora.Controllers
{
    public class FilmeController : Controller
    {
        private readonly IFilmeRepository _filmeRepository;

        public FilmeController(IFilmeRepository filmeRepository)
        {
            _filmeRepository = filmeRepository;
        }

        public IActionResult List()
        {
            var filmes = _filmeRepository.Todos;
            return View(filmes);
        }

    }
}
