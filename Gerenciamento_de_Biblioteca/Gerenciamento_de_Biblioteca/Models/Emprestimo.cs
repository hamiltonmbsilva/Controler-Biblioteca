using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Gerenciamento_de_Biblioteca.Models
{
    [Serializable]
    [Table("emprestimo")]
    public class Emprestimo
    {
        [Key]
        [Required, Column("id")]
        public int IdEmprestimo { get; set; }

        [Required, Column("data_devolucao")]
        public DateTime DataDevolucao { get; set; }

        [Required, Column("observacao")]
        public string Observacao { get; set; }
    }
}
