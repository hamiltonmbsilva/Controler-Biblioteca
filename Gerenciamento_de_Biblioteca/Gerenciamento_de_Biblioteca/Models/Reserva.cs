using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gerenciamento_de_Biblioteca.Models
{
    [Serializable]
    [Table("reserva")]
    public class Reserva
    {
        [Key]
        [Required, Column("id")]
        public int IdReserva { get; set; }

        [Required, Column("data_devolucao")]
        public DateTime DataDevolucao { get; set; }
    }
}
