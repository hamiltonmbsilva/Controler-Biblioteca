using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gerenciamento_de_Biblioteca.Models
{
    [Serializable]
    [Table("autor")]
    public class Autor
    {
        [Key]
        [Required, Column("id")]
        public int IdAutor { get; set; }

        [Required, Column("nome")]
        public string Nome { get; set; }
    }
}
