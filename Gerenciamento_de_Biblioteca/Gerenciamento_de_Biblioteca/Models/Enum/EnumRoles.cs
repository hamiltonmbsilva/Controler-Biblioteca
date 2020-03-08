using System.ComponentModel;

namespace Gerenciamento_de_Biblioteca.Models.Enum
{
    public enum EnumRoles
    {
        [Description("Gerente Biblioteca")]
        Gerente_Biblioteca = 0,
        Bibliotecario = 1,
        [Description("Setor Atendimento")]
        Setor_Atendimento = 2,
        Usuario = 3
    }
}
