using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gerenciamento_de_Biblioteca.Models
{
    [Serializable]
    [Table("exemplar")]
    public class Exemplar
    {
        [Key]
        [Required, Column("id")]
        public int IdExemplar { get; set; }

        [Required, Column("circular")]
        public string Circular { get; set; }

        [Required, Column("numero")]
        public int Numero { get; set; }

        

    }
}
