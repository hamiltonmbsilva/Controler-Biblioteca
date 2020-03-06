using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gerenciamento_de_Biblioteca.Models
{
    [Serializable]
    [Table("renovacao")]
    public class Renovacao
    {
        [Key]
        [Required, Column("id")]
        public int IdRenovacao { get; set; }

        [Required, Column("quantidade")]
        public int Quantidade { get; set; }
    }
}
