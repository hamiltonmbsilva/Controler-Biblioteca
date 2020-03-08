using Gerenciamento_de_Biblioteca.Models.Enum;
using Microsoft.EntityFrameworkCore;
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

        [Required, Column("nome_completo")]
        //[StringLength(100, ErrorMessage = "O Campo {0} pode ter no máximo {1} e minimo {2} caracteres", MinimumLength = 7)]
        public string NomeCompelto { get; set; }

        [Required, DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        public string Senha { get; set; }

        [Required, Column("data_nascimento")]
        public DateTime DataNascimento { get; set; }

        [Required]
        public string Rua { get; set; }
       
        public int Numero { get; set; }
        
        public string Complemento { get; set; }

        [Required]
        public string Bairro { get; set; }

        [Required]
        public string Cidade { get; set; }

        [Required]
        public string Estado { get; set; }

        
        public string Multa { get; set; }

        [Required]
        public EnumRoles Roles { get; set; }

        public Guid Token { get; set; }



        //Relacionamento


        public static void Map(ModelBuilder modelBuilder)
        {
           
                
        }
    }
}
