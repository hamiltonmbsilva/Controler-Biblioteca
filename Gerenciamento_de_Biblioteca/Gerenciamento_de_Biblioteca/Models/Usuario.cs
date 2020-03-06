using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gerenciamento_de_Biblioteca.Models
{
    [Serializable]
    [Table("usuario")]
    public class Usuario
    {
        [Key]
        [Required, Column("id")]
        public int IdUsuario { get; set; }

        [Required, Column("nome")]
        //[StringLength(100, ErrorMessage = "O Campo {0} pode ter no máximo {1} e minimo {2} caracteres", MinimumLength = 7)]
        public string Nome { get; set; }

        [Required, Column("data_nascimento")]
        public DateTime DataNascimento { get; set; }

        [Required, Column("rua")]
        public string Rua { get; set; }

        [Required, Column("numero")]
        public int Numero { get; set; }

        [Required, Column("complemento")]
        public string Complemento { get; set; }

        [Required, Column("bairro")]
        public string Bairro { get; set; }

        [Required, Column("cidade")]
        public string Cidade { get; set; }

        [Required, Column("estado")]
        public string Estado { get; set; }

        [Required, Column("multa")]
        public string Multa { get; set; }

        //Relacionamento
        public virtual Login Login { get; set; }
    }
}
