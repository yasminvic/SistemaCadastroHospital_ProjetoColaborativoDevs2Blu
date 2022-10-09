using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Devs2Blu.ProjetosAula.SistemaCadastro.Models.Enums;

namespace Devs2Blu.ProjetosAula.SistemaCadastro.Models.Model
{
    public class Fornecedor
    {
        public Int32 Id { get; set; }
        public String TipoFornecedor { get; set; }
        public Pessoa Pessoa { get; set; }
        public Fornecedor()
        {
            Pessoa = new Pessoa();
            Pessoa.TipoPessoa = TipoPessoa.PJ;
        }
    }
}
