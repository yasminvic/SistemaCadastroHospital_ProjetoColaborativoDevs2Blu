using System.ComponentModel;

namespace Devs2Blu.ProjetosAula.Models.Enum
{ 
    public enum FlStatus
    {
        [Description("Excluído")]
        E = 0, //excluído

        [Description("Ativo")]
        A = 1, // ativo

        [Description("Inativo")]
        I = 2 // inativo
    }
}