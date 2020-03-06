using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gerenciamento_de_Biblioteca.Models
{
    [Serializable]
    [Table("autor")]
    public class Livro
    {
        [Key]
        [Required, Column("id")]
        public int IdLivro { get; set; }

        [Required, Column("titulo")]
        public string Titulo { get; set; }

        [Required, Column("isbn")]
        public string ISBN { get; set; }

        [Required, Column("edicao")]
        public string Edicao { get; set; }

        [Required, Column("editora")]
        public string Editora { get; set; }

        [Required, Column("ano_lacamento")]
        public int AnoLancamento { get; set; }

        [Required, Column("imagem")]
        public string Imagem { get; set; }

        [Required, Column("acervo")]
        public bool Acervo { get; set; }
    }
}
