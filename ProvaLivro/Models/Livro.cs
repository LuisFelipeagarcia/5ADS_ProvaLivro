using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProvaLivro.Models
{
    public class Livro
    {
        [Key]
        public long? LivroID { get; set; }
        [Display(Name = "Código do Livro")]
        [Required]
        public string CodLivro { get; set; }
        [Display(Name = "Título")]
        [Required]
        public string Titulo { get; set; }
        [Required]
        public string Autor { get; set; }
        [Display(Name = "Editóra")]
        [Required]
        public string Editora { get; set; }
        [Display(Name = "Observação")]
        [Required]
        public string Observacao { get; set; }
        [Display(Name = "Descrição")]
        [Required]
        public string Descricao { get; set; }
        [Display(Name = "Quantidade Estoque")]
        [Required]
        public string Qtda { get; set; }
    }
}
