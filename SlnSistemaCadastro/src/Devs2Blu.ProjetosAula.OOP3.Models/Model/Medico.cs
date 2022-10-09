using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Devs2Blu.ProjetosAula.SistemaCadastro.Models.Enums;

namespace Devs2Blu.ProjetosAula.SistemaCadastro.Models.Model
{
    public class Medico
    {
        public Int32 Id { get; set; }
        public String CRM { get; set; }
        public String Especialidade { get; set; }
        public Pessoa Pessoa { get; set; }
        public Medico()
        {
            Pessoa = new Pessoa();
            Pessoa.TipoPessoa = TipoPessoa.PF;
        }
    }
}
