using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Devs2Blu.ProjetosAula.SistemaCadastro.Models.Enums;

namespace Devs2Blu.ProjetosAula.SistemaCadastro.Models.Model
{
    public class Recepcionista
    {
        public Int32 CodigoRecepcionista { get; set; }
        public String Setor { get; set; }
        public Pessoa Pessoa { get; set; }
        public Recepcionista()
        {
            Pessoa = new Pessoa();
            Pessoa.TipoPessoa = TipoPessoa.PF;
        }
    }
}
