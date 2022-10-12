using Devs2Blu.ProjetosAula.OOP3.Models.Model;
using Devs2Blu.ProjetosAula.SistemaCadastro.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.SistemaCadastro.Forms.Interface
{
    public interface IComanndSQL
    {

        Pessoa InsertPes(Pessoa pessoa);
        Paciente InsertPac(Paciente paciente);
        Endereco InsertEnd(Endereco endereco);
        void Delete(Int32 idpessoa);
    }
}
