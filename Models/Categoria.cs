using Locadora.Models.Base;
using System.ComponentModel.DataAnnotations;

namespace Locadora.Models
{
    public class Categoria : EntidadeBase
    {
        [StringLength(400, MinimumLength = 5)]
        public string Descricao { get; set; }

        public List<Filme> Filmes { get; set; }
    }
}
