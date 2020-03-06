using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gerenciamento_de_Biblioteca.Models
{
    [Serializable]
    [Table("login")]
    public class Login
    {
        [Key]
        [Required, Column("id")]
        public int IdLogin { get; set; }

        //relacionamento
        public virtual Usuario Usuario { get; set; }

        //public static void Map(DbModelBuilder modelBuilder)
        //{ 
        //}

    }
}
