using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gerenciamento_de_Biblioteca.Models
{
    [Serializable]
    [Table("categoria")]
    public class Categoria
    {
        [Key]
        [Required, Column("id")]
        public int IdCategoria { get; set; }

        [Required, Column("nome")]
        public string Nome { get; set; }

        [Required, Column("descricao")]
        public string Descricao { get; set; }

        [Required, Column("assunto")]
        public string Assunto { get; set; }
    }
}
