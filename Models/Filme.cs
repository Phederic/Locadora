using Locadora.Models.Base;
using System.ComponentModel.DataAnnotations;

namespace Locadora.Models
{
    public class Filme : EntidadeBase
    {
        [Required]
        [StringLength(100,MinimumLength = 5)]
        public string Nome { get; set; }

        [StringLength(400, MinimumLength = 5)]
        public string Sinopse { get; set; }
        public bool Alugado { get; set; }    

        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}
