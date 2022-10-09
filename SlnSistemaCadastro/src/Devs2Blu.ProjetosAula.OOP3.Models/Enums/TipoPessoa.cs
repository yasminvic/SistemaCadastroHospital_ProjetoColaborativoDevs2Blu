using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.SistemaCadastro.Models.Enums
{
    public enum TipoPessoa
    {
        [Description("Pessoa Fisica")]
        PF = 0,
        [Description("Pessoa Juridica")]
        PJ = 1
    }
}
